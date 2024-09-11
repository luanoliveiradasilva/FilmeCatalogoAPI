using app.Models;
using app.Models.Dtos.Filmes;

namespace app.Repository
{
    public interface IFilmesRepository
    {
        Task<IEnumerable<Filmes>> GetAllFilmes();
        Task<IEnumerable<Diretores>> GetAllDiretores();
        Task<IEnumerable<Generos>> GetAllGeneros();
        Task<IEnumerable<FilmesDto>> GetFilmesAsync(int pageNumber, int pageSize);

    }
}