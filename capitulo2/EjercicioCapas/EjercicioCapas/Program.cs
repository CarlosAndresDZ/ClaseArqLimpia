using EjercicioCapas.Data.Repositories;
using EjercicioCapas.Data;
using Microsoft.EntityFrameworkCore;
//using EjercicioCapas.Bussiness.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inyectar contexto de BD (crear el objeto en tiempo de ejecucion)
builder.Services.AddDbContext<AppDBContext>(
    context => {
        context.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection")  /*??"BackupConnection" */ );
    }
    );
//Inyectar Repositorios
builder.Services.AddScoped<AutorRepository>();
builder.Services.AddScoped<BookRepository>();

// inyectando service
//builder.Services.AddScoped<IReservationService, ReservationServiceImpl>();


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

app.UseAuthorization();

app.MapControllers();

app.Run();
