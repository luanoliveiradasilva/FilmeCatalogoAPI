
using app.Models;
using app.Repository;

namespace app.Services
{
    public class DiretoresService(IFilmesRepository iFilmesRepository) : IDiretoresService
    {

        private readonly IFilmesRepository _iFilmesRepository = iFilmesRepository;

        public async Task<IEnumerable<Diretores>?> GetAllDiretores()
        {
            try
            {
                return await _iFilmesRepository.GetAllDiretores();
            }
            catch (Exception ex)
            {
                throw new Exception("Error not found", ex);
            }

        }
    }
}