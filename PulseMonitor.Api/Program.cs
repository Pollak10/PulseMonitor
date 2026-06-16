var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

// This will be the Middleware
app.UseAuthorization();

// Map Controller Routes
app.MapControllers();

app.Run();