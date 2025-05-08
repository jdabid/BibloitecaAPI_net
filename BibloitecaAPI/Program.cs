using BibloitecaAPI.Datos;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//area de servicios
builder.Services.AddControllers().AddJsonOptions(opciones =>
opciones.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddDbContext<AplicationDbContext>(opciones => opciones.UseSqlServer("name= DefaultConnection"));

var app = builder.Build();

//area de middlewares
app.MapControllers();



app.Run();
