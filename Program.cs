using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ZooPandica.Data;
using ZooPandica.Models;
using ZooPandica.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var jwtSettings = builder.Configuration.GetSection("Jwt");

var jwtKey = Environment.GetEnvironmentVariable("JWT_SECRET", EnvironmentVariableTarget.Process)
    ?? throw new InvalidOperationException("JWT_SECRET is not set!");

var jwtIssuer = jwtSettings["Issuer"]
    ?? throw new InvalidOperationException("JWT Issuer is not set in configuration.");

var jwtAudience = jwtSettings["Audience"]
    ?? throw new InvalidOperationException("JWT Audience is not set in configuration.");

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.RequireHttpsMetadata = false;
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey)),
            ValidateIssuer = true,
            ValidIssuer = jwtIssuer,
            ValidateAudience = true,
            ValidAudience = jwtAudience,
            ValidateLifetime = true
        };
    });

builder.Services.AddAuthorization();

builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
