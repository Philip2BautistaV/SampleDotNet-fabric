var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "DataPlatform in main on Sunday");

app.Run();
