using app.Models.DTO;
using app.Repository;

namespace app.Services
{
    public class FilmesNetServices(IFilmesRespository repository) : IFilmesNetServices
    {
        private readonly IFilmesRespository _repository = repository;

        public async Task<IEnumerable<FilmesDTO>> GetFilmes(int pageNumber, int pageSize)
        {
            var filmesDetalhados = await _repository.GetFilmesAsync(pageNumber, pageSize);
            
            return filmesDetalhados;
        }

    }
}