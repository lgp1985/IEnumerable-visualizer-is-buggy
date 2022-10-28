using System.Diagnostics;

var defaultHttpContext = new DefaultHttpContext();
defaultHttpContext.Request.Headers.Add("Authorization", "Sample Value");
defaultHttpContext.Request.Headers.Add("Another Header", new[] { "Sample Value 2", "Another Sample Value" });
var inspectMe = defaultHttpContext.Request.Headers;
Debugger.Break();


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
