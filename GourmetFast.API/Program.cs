using GourmetFast.API.Controllers;
using GourmetFast.Services.Interfaces;
using GourmetFast.Services.Services;
using GourmetFast.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using GourmetFast.Repository.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. 
builder.Services.AddControllers();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

// Adicione o contexto ao contêiner de injeção de dependência
builder.Services.AddIfrastructure(builder.Configuration);
//builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


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
