using app.Models.DTO;

namespace app.Repository
{
    public interface IFilmesRespository
    {
        /* Task<IEnumerable<Filmes>> GetFilmesAsync(); */
        Task<IEnumerable<FilmesDTO>> GetFilmesAsync(int pageNumber, int pageSize);
    }
}