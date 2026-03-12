
using Application;
using Infra;
using WebApi;

var builder = WebApplication.CreateBuilder(args)    ;
builder.Services.AddControllers();
builder.Services.AddAppDI(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
//app.MapGet("/", () => "Hello World!");

app.Run();
