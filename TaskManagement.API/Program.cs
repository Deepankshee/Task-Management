using TaskManagement.API;
using TaskManagement.Application.Services;
using TaskManagement.Application.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(ApplicationProfile));
builder.Services.AddScoped<ITaskService,TaskService>();
var app = builder.Build();
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
