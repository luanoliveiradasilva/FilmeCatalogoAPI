using app.Models;
using app.Models.Dtos.Filmes;

namespace app.Repository
{
    public interface IFilmesRespository
    {
        Task<IEnumerable<FilmesDto>> GetFilmesAsync();
        Task<IEnumerable<FilmesAllDTO>> GetFilmesAllDatasAsync(int pageNumber, int pageSize);
    }
}