var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add Swagger services to the container
builder.Services.AddEndpointsApiExplorer();  // Adds the necessary services for OpenAPI/Swagger
builder.Services.AddSwaggerGen();  // Configures Swagger generation

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Enable the Swagger UI only in development mode
    app.UseSwagger(); 
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();