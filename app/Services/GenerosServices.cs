using app.Models;
using app.Repository;

namespace app.Services
{
    public class GenerosServices(IFilmesRepository iFilmesRespository) : IGenerosServices
    {

        private readonly IFilmesRepository _ifilmesRespository = iFilmesRespository;

        public async Task<IEnumerable<Generos>> GetAllGeneros()
        {
            try
            {
                return await _ifilmesRespository.GetAllGeneros();
            }
            catch (Exception ex)
            {
                throw new Exception("Error not found", ex);
            }

        }
    }
}