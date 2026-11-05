using Microsoft.EntityFrameworkCore;
using SmartQueue.Data;
using SmartQueue.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var connectionString = Environment.GetEnvironmentVariable("DATABASE_URL")
    ?? "Host=localhost;Port=5432;Database=app;Username=app;Password=app";

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<TicketService>();

var app = builder.Build();

app.UseStaticFiles();
app.MapRazorPages();

for (var i = 0; i < 30; i++)
{
    try
    {
        using var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        db.Database.EnsureCreated();
        break;
    }
    catch
    {
        Thread.Sleep(2000);
    }
}

app.Run();