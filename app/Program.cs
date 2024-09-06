using app.Infrastructure;
using app.Repository;
using app.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<FilmesNetDbContext>(options => options.UseMySql(builder.Configuration.GetConnectionString("FilmeNet"), new MySqlServerVersion(new Version(8, 0, 26))));

builder.Services.AddScoped<IFilmesRespository, FilmesRespository>();
builder.Services.AddScoped<IFilmesNetServices, FilmesNetServices>();
builder.Services.AddScoped<IDiretoresService, DiretoresService>();
builder.Services.AddScoped<IGenerosServices, GenerosServices>();
builder.Services.AddControllers();
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
