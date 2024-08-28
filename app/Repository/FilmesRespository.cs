using app.Infrastructure;
using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Repository
{
    public class FilmesRespository(FilmesNetDbContext context) : IFilmesRespository
    {

        private readonly FilmesNetDbContext dbContext = context;

        public async Task<IEnumerable<Filmes>> GetFilmesAsync() => await dbContext.Filmes.ToListAsync();
    }
}