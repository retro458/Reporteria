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
        //  Buscar empresa por subdominio
        var empresa = await _admin.Empresas
            .FirstOrDefaultAsync(e => e.Subdominio == req.Tenant && e.Activa == true);

        if (empresa == null)
            return Unauthorized(new { message = "Empresa no encontrada" });

        //  Buscar usuario
        var usuario = await _admin.Usuarios
            .FirstOrDefaultAsync(u =>
                u.EmpresaId == empresa.EmpresaId &&
                u.Username == req.Username &&
                u.Activo == true);

        if (usuario == null)
            return Unauthorized(new { message = "Usuario o contraseña incorrectos" });

        //  Verificar password 
        if (!BCrypt.Net.BCrypt.Verify(req.Password, usuario.PasswordHash))
            return Unauthorized(new { message = "Usuario o contraseña incorrectos" });

        // Generar JWT
        var token = GenerarToken(usuario.Username, empresa.Subdominio,
                                  empresa.DbName, usuario.Rol ?? string.Empty);

        //   CONFIGURAR COOKIE HTTPONLY 
        var isDev = _config["ASPNETCORE_ENVIRONMENT"] == "Development";

        var cookieOptions = new CookieOptions
        {
            HttpOnly = true,
            Secure = true, // Cloudflare siempre usa HTTPS
            SameSite = SameSiteMode.None, // Obligatorio para subdominios distintos
            Expires = DateTime.UtcNow.AddHours(8),
            Path = "/"
        };

        // Inyectamos la cookie en la respuesta
        Response.Cookies.Append("Authorization", token, cookieOptions);

        //  Devolvemos la respuesta SIN el token (el token ya va en la cookie)
        return Ok(new
        {
            // token = "", // Ya no es necesario enviarlo aquí
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

    [HttpPost("logout")]
public IActionResult Logout()
{
    // Creamos opciones de cookie que coincidan exactamente con las del login
    var cookieOptions = new CookieOptions
    {
        HttpOnly = true,
        Secure = true, 
        SameSite = SameSiteMode.None,
        Path = "/",
        Expires = DateTime.UtcNow.AddDays(-1) //  Seteamos una fecha pasada para matarla
    };

    // Al hacer Append con una fecha pasada, el navegador la borra de inmediato
    Response.Cookies.Append("Authorization", "", cookieOptions);

    return Ok(new { message = "Sesión cerrada correctamente" });
}
}

// ── DTO
public class LoginRequest
{
    public string Tenant { get; set; } = "";
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";
}