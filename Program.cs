var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "DataPlatform Deployment in develop!");

app.Run();
