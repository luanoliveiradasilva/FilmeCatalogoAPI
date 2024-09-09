using app.Infrastructure;
using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Repository
{
    public class FilmesRepository(FilmesNetDbContext context) : IFilmesRepository
    {

        private readonly FilmesNetDbContext dbContext = context;

        /*   public async Task<IEnumerable<FilmesDto>> GetFilmesAsync()
          {
              var querySelect = from filme in dbContext.Filmes
                                select new FilmesDto
                                {
                                    NomeFilme = filme.NomeFilme,
                                    DataLancamento = filme.DataLancamento,
                                    Descricao = filme.Descricao,
                                };
              return await querySelect.ToListAsync();
          }

          public async Task<IEnumerable<FilmesAllDTO>> GetFilmesAllDatasAsync(int pageNumber, int pageSize)
          {
              var querySelect = from filme in dbContext.Filmes
                                join genero in dbContext.Generos on filme.IdGenero equals genero.IdGenero
                                join diretor in dbContext.Diretores on filme.IdDiretor equals diretor.IdDiretor
                                select new FilmesAllDTO
                                {
                                    NomeFilme = filme.NomeFilme,
                                    DataLancamento = filme.DataLancamento,
                                    Descricao = filme.Descricao,
                                    TipoDoGenero = genero.TipoDoGenero,
                                    NomeDiretor = diretor.NomeDiretor
                                };

              return await querySelect
                  .Skip((pageNumber - 1) * pageSize)
                  .Take(pageSize)
                  .ToListAsync();
          }

          public async Task<IEnumerable<DiretoresDto>> GetAllDiretoresAsync()
          {
              var querySelect = from diretor in dbContext.Diretores
                                select new DiretoresDto
                                {
                                    NomeDiretor = diretor.NomeDiretor
                                };

              return await querySelect.ToListAsync();
          }

          public async Task<IEnumerable<GenerosDto>> GetAllGenerosAsync()
          {
              var querySelect = from genero in dbContext.Generos
                                select new GenerosDto
                                {
                                    TipoDoGenero = genero.TipoDoGenero
                                };
              return await querySelect.ToListAsync();
          }
   */
        public async Task<IEnumerable<Filmes>> GetAllFilmes() => (await dbContext.Filmes.ToListAsync()).Select(m => (Filmes)m);

        public async Task<IEnumerable<Diretores>> GetAllDiretores() => (await dbContext.Diretores.ToListAsync()).Select(d => (Diretores)d);

        public async Task<IEnumerable<Generos>> GetAllGeneros() => (await dbContext.Generos.ToListAsync()).Select(g => (Generos)g);
    }
}