using coffee_webapi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Register context
builder.Services.AddDbContext<CoffeeApiContext>(opt => 
    opt.UseSqlite(configuration.GetConnectionString("DefaultConnection")));
// Register controllers
builder.Services.AddControllers();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Coffee API", Version = "v1" });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi(); // Map OpenAPI endpoints
    app.UseSwagger(); // Enable Swagger middleware
    app.UseSwaggerUI(); // Enable Swagger UI
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();