using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ReportesAPI.Data;
using BCrypt.Net;


/*

    @Erick Baudriz: Este controlador se encarga de manejar la autenticación de los usuarios.
        - El endpoint /api/auth/login recibe el subdominio (tenant), username y password.
        - Verifica que la empresa exista y esté activa, luego busca el usuario dentro de esa empresa.
        - Si las credenciales son correctas, genera un JWT con claims que incluyen el tenant, dbName y rol del usuario.
        - El token se devuelve al cliente, quien lo usará para autenticar futuras solicitudes a los endpoints protegidos.
    
        Nota: Por ahora la verificación de password es en texto plano para simplificar

    @Author: Erick Baudriz

*/

namespace ReportesAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AdminContext _admin;
    private readonly IConfiguration _config;

    public AuthController(AdminContext admin, IConfiguration config)
    {
        _admin = admin;
        _config = config;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest req)
    {
        // 1. Buscar empresa por subdominio
        var empresa = await _admin.Empresas
            .FirstOrDefaultAsync(e => e.Subdominio == req.Tenant && e.Activa == true);

        if (empresa == null)
            return Unauthorized(new { message = "Empresa no encontrada" });

        // 2. Buscar usuario
        var usuario = await _admin.Usuarios
            .FirstOrDefaultAsync(u =>
                u.EmpresaId == empresa.EmpresaId &&
                u.Username == req.Username &&
                u.Activo == true);

        if (usuario == null)
            return Unauthorized(new { message = "Usuario o contraseña incorrectos" });

        // 3. Verificar password 
      if (!BCrypt.Net.BCrypt.Verify(req.Password, usuario.PasswordHash))
            return Unauthorized(new { message = "Usuario o contraseña incorrectos" });

        // 4. Generar JWT
        var token = GenerarToken(usuario.Username, empresa.Subdominio,
                                  empresa.DbName, usuario.Rol ?? string.Empty);

        return Ok(new
        {
            token,
            username = usuario.Username,
            rol = usuario.Rol,
            empresa = empresa.Nombre,
            dbName = empresa.DbName,
            tenant = empresa.Subdominio
        });
    }

    private string GenerarToken(string username, string tenant,
                                  string dbName, string rol)
    {
        var claims = new[]
        {
            new Claim(ClaimTypes.Name,           username),
            new Claim("tenant",                  tenant),
            new Claim("dbName",                  dbName),
            new Claim(ClaimTypes.Role,           rol)
        };

        var key = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _config["Jwt:Issuer"],
            audience: _config["Jwt:Audience"],
            claims: claims,
            expires: DateTime.UtcNow.AddHours(8),
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}

// ── DTO
public class LoginRequest
{
    public string Tenant { get; set; } = "";
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";
}