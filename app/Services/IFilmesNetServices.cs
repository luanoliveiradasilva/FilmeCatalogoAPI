using app.Models;

namespace app.Services
{
    public interface IFilmesNetServices
    {
        Task<IEnumerable<Filmes>> GetAllMovies();/* 
        Task<IEnumerable<FilmesAllDTO>> GetFilmesAllDatas(int pageNumber, int pageSize); */
    }
}