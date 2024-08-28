using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Infrastructure
{
    public class FilmesNetDbContext: DbContext
    {
        public FilmesNetDbContext(DbContextOptions<FilmesNetDbContext> options): base(options){}

        public DbSet<Filmes> Filmes{get; set;}
        
    }
}