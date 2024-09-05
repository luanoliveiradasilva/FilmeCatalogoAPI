using app.Models.Dtos.Filmes;

namespace app.Services
{
    public interface IFilmesNetServices
    {
        Task<IEnumerable<FilmesDto>> GetFilmes();
        Task<IEnumerable<FilmesAllDTO>> GetFilmesAllDatas(int pageNumber, int pageSize);
    }
}