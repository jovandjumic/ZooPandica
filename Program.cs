using Microsoft.EntityFrameworkCore;
using ZooPandica.Data;

var builder = WebApplication.CreateBuilder(args);

// Konfiguracija konekcije sa bazom
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Omogućavamo rad sa kontrolerima
builder.Services.AddControllers();

var app = builder.Build();

// Omogućavanje HTTPS
app.UseHttpsRedirection();

// Mapiranje API kontrolera
app.MapControllers();

app.Run();
