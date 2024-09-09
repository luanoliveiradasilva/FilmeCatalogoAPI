
using app.Models.Dtos.Diretores;
using app.Repository;

namespace app.Services
{
    public class DiretoresService(IFilmesRepository iFilmesRepository) : IDiretoresService
    {
/* 
        private readonly IFilmesRepository _iFilmesRepository = iFilmesRepository;

        public async Task<IEnumerable<DiretoresDto>> GetAllDiretores()
        {
            return await _iFilmesRepository.GetAllDiretoresAsync();
        } */
    }
}