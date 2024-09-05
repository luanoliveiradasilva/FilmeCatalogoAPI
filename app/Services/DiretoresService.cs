
using app.Models.Dtos.Diretores;
using app.Repository;

namespace app.Services
{
    public class DiretoresService(IFilmesRespository iFilmesRepository) : IDiretoresService
    {

        private readonly IFilmesRespository _iFilmesRepository = iFilmesRepository;

        public async Task<IEnumerable<DiretoresDto>> GetAllDiretores()
        {
            return await _iFilmesRepository.GetAllDiretoresAsync();
        }
    }
}