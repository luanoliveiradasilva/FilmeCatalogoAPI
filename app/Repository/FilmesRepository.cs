using app.Infrastructure;
using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Repository
{
    public class FilmesRepository(FilmesNetDbContext context) : IFilmesRepository
    {

        private readonly FilmesNetDbContext dbContext = context;

        public async Task<IEnumerable<Filmes>> GetAllFilmes() => (await dbContext.Filmes.ToListAsync()).Select(m => (Filmes)m);

        public async Task<IEnumerable<Diretores>> GetAllDiretores() => (await dbContext.Diretores.ToListAsync()).Select(d => (Diretores)d);

        public async Task<IEnumerable<Generos>> GetAllGeneros() => (await dbContext.Generos.ToListAsync()).Select(g => (Generos)g);
    }
}