var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "created project");

app.Run();
