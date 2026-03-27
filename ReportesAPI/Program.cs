using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ReportesAPI.Data;
using ReportesAPI.Services;
using Serilog;
var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://*:5169");
builder.Host.UseWindowsService();
// ═══════════════════════════════════════
// 1. SERVICIOS
// ═══════════════════════════════════════

// Controladores
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ── Base de datos Admin (tenant management)
builder.Services.AddDbContext<AdminContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AdminDb")));

// ── Base de datos ControlDTE (datos del cliente)
// Este NO se registra fijo — se crea dinámicamente por tenant
// Solo se registra si se necesita acceso directo sin multi-tenant
builder.Services.AddDbContext<ControlDTEContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ControlDTE")));

builder.Services.AddScoped<IKardexService, KardexService>();
builder.Services.AddScoped<IReportGeneratorService, ReportGeneratorService>();

// Serillog 
Log.Logger = new LoggerConfiguration()
   .MinimumLevel.Debug()
    .WriteTo.Console()
    .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day, retainedFileCountLimit : 7)
    .CreateLogger();

builder.Host.UseSerilog();
builder.Host.UseWindowsService();

// ── JWT Authentication
var jwtKey = builder.Configuration["Jwt:Key"];
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer           = true,
            ValidateAudience         = true,
            ValidateLifetime         = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer              = builder.Configuration["Jwt:Issuer"],
            ValidAudience            = builder.Configuration["Jwt:Audience"],
            IssuerSigningKey         = new SymmetricSecurityKey(
                                           Encoding.UTF8.GetBytes(jwtKey!))
        };
    });

builder.Services.AddAuthorization();

// ── CORS (permite que el Vue se conecte)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowVue", policy =>
    {
        policy.WithOrigins(
                "http://localhost:5173",       // Vue dev
                "  " // Producción
              )
              
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// ═══════════════════════════════════════
// 2. PIPELINE (orden importa)
// ═══════════════════════════════════════

try
{
    Log.Information("Iniciando ReportesAPI...");
    var app = builder.Build();
    app.UseRouting();
    app.UseCors("AllowVue");         // CORS antes de Auth
    app.UseAuthentication();          // Primero Authentication
    app.UseAuthorization();           // Luego Authorization

       if (app.Environment.IsDevelopment())
       /* app.UseSwagger();
        app.UseSwaggerUI(c => 
        {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Reportes API V1");
        // Esto asegura que al entrar a /swagger se vea la interfaz
        c.RoutePrefix = "swagger"; 
        });*/

    app.MapControllers();

    app.Run();    

 
}
catch (Exception ex)
{
    Log.Fatal(ex, "La aplicación falló al iniciar");
}
finally
{
    Log.CloseAndFlush();
}
// app.UseHttpsRedirection()

