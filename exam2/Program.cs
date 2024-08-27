// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// app.MapGet("/", () => "Hello World!");

// app.Run();

//0.1.1
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "Hello World");
app.Urls.Add("http://localhost:8080"); 
app.Run();
