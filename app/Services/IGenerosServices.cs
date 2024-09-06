using app.Models.Dtos.Generos;

namespace app.Services
{
    public interface IGenerosServices
    {
        Task<IEnumerable<GenerosDto>> GetAllGeneros();
    }
}