using TaskManagement.API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(typeof(ApplicationProfile));
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
