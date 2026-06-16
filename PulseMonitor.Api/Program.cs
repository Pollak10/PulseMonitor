using Microsoft.EntityFrameworkCore;
using PulseMonitor.Api.Data;


var builder = WebApplication.CreateBuilder(args);

//Registar Services
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// This will be the Middleware
app.UseAuthorization();

// Map Controller Routes
app.MapControllers();

app.Run();