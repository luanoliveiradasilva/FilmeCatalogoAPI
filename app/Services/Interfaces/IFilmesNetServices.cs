using app.Models;

namespace app.Services
{
    public interface IFilmesNetServices
    {
        Task<IEnumerable<Filmes>?> GetAllMovies();
    }
}