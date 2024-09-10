using app.Models;
using app.Models.Dtos.Generos;

namespace app.Services
{
    public interface IGenerosServices
    {
        Task<IEnumerable<Generos>?> GetAllGeneros();
    }
}