var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "DataPlatform in develop on Sunday");

app.Run();
