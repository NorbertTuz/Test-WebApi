using Microsoft.EntityFrameworkCore;
using MoviesApi.Models;
using MoviesApi.Data;


var builder = WebApplication.CreateBuilder(args);



var connectionString = builder.Configuration
    .GetConnectionString("MovieApiDBConnection") ?? 
    throw new InvalidOperationException("Connection string 'MovieApiDBConnection' not found.");

builder.Services.AddDbContext<MoviesDbContext>(options =>
    options.UseSqlite(connectionString));

builder.Services.AddControllers();

// Add services to the container.
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


app.UseAuthorization();

app.MapControllers();

app.Run();

