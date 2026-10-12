var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content("""
<!DOCTYPE html>
<html>
<head><title>SmartQueue</title></head>
<body style="font-family: Arial; text-align: center; margin-top: 100px;">
    <h1>SmartQueue</h1>
    <p>Система электронной очереди</p>
    <p>Версия 0.0.1</p>
    <p>Разработка продолжается</p>
</body>
</html>
""", "text/html; charset=utf-8"));

app.Run();