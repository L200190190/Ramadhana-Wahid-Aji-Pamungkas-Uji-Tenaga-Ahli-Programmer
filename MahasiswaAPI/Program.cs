using MahasiswaAPI.Context;
using MahasiswaAPI.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Globalization;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


//public ConfigurationController(IConfiguration configuration)
//{
  //  configuration = configuration;
//}

// public IConfiguration Configuration {  get; }

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<MahasiswaRepository>();
builder.Services.AddDbContext<MyContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("API")));

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
