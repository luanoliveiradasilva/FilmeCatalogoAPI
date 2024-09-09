using app.Models.Dtos.Generos;
using app.Repository;

namespace app.Services
{
    public class GenerosServices(IFilmesRepository iFilmesRespository) : IGenerosServices
    {

/*         private readonly IFilmesRepository _ifilmesRespository = iFilmesRespository;

        public async Task<IEnumerable<GenerosDto>> GetAllGeneros()
        {
            return await _ifilmesRespository.GetAllGenerosAsync();
        } */
    }
}