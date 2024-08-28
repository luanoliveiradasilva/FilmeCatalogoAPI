using app.Infrastructure;
using app.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace app.Repository
{
    public class FilmesRespository(FilmesNetDbContext context) : IFilmesRespository
    {

        private readonly FilmesNetDbContext dbContext = context;
/* 
        public async Task<IEnumerable<Filmes>> GetFilmesAsync() => await dbContext.Filmes.ToListAsync(); */

        public async Task<IEnumerable<FilmesDTO>> GetFilmesAsync(int pageNumber, int pageSize)
        {
            var querySelect = from filme in dbContext.Filmes
                              join genero in dbContext.Generos on filme.IdGenero equals genero.IdGenero
                              join diretor in dbContext.Diretores on filme.IdDiretor equals diretor.IdDiretor
                              select new FilmesDTO
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
    }
}