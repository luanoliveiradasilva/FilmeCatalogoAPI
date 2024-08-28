using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Infrastructure
{
    public class FilmesNetDbContext(DbContextOptions<FilmesNetDbContext> options) : DbContext(options)
    {
        public DbSet<Filmes> Filmes{get; set;}
    }
}