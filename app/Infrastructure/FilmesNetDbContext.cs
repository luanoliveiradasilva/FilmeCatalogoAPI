using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Infrastructure
{
    public class FilmesNetDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Filmes> Filmes { get; set; }
        public DbSet<Diretores> Diretores { get; set; }
        public DbSet<Generos> Generos { get; set; }
    }
}