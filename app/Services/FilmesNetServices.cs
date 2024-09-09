using app.Models;
using app.Repository;
using Microsoft.Extensions.Logging;

namespace app.Services
{
    public class FilmesNetServices(IFilmesRepository repository) : IFilmesNetServices
    {

        private readonly IFilmesRepository _repository = repository;

        public async Task<IEnumerable<Filmes>> GetAllMovies()
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
        /* 
       public async Task<IEnumerable<FilmesDto>> GetFilmes() => await _repository.GetFilmesAsync();

       public async Task<IEnumerable<FilmesAllDTO>> GetFilmesAllDatas(int pageNumber, int pageSize)
       {
           return await _repository.GetFilmesAllDatasAsync(pageNumber, pageSize);
       } */
    }
}