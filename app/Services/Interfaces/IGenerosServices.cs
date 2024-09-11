using app.Models;

namespace app.Services
{
    public interface IGenerosServices
    {
        Task<IEnumerable<Generos>?> GetAllGeneros();
    }
}