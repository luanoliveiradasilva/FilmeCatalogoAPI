using app.Models.Dtos.Filmes;
using app.Repository;

namespace app.Services
{
    public class FilmesNetServices(IFilmesRespository repository) : IFilmesNetServices
    {
        private readonly IFilmesRespository _repository = repository;

        public async Task<IEnumerable<FilmesDto>> GetFilmes() => await _repository.GetFilmesAsync();

        public async Task<IEnumerable<FilmesAllDTO>> GetFilmesAllDatas(int pageNumber, int pageSize)
        {
            return await _repository.GetFilmesAllDatasAsync(pageNumber, pageSize);
        }
    }
}