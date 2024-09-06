using app.Models.Dtos.Generos;
using app.Repository;

namespace app.Services
{
    public class GenerosServices(IFilmesRespository iFilmesRespository) : IGenerosServices
    {

        private readonly IFilmesRespository _ifilmesRespository = iFilmesRespository;

        public async Task<IEnumerable<GenerosDto>> GetAllGeneros()
        {
            return await _ifilmesRespository.GetAllGenerosAsync();
        }
    }
}