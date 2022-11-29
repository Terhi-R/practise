var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/greet/{name}", (string name) => $"Welcome to SALT, {name}!");

app.Run();
