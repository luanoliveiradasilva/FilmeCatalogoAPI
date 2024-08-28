using app.Models;

namespace app.Repository
{
    public interface IFilmesRespository
    {
        Task<IEnumerable<Filmes>> GetFilmesAsync();
    }
}