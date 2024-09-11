using app.Models;
using app.Repository;

namespace app.Services
{
    public class FilmesNetServices(
        IFilmesRepository repository) : IFilmesNetServices
    {
        private readonly IFilmesRepository _repository = repository;

        public async Task<IEnumerable<Filmes>?> GetAllMovies()
        {
            try
            {
                var movies = _repository.GetAllFilmes();
                return await movies;
            }
            catch (Exception ex)
            {
                throw new Exception("Error not found", ex);
            }
        }
    }
}