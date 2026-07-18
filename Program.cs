var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "DataPlatform Deployment in Production");

app.Run();
