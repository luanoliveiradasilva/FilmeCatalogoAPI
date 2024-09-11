using app.Models;

namespace app.Services
{
    public interface IDiretoresService
    {
        Task<IEnumerable<Diretores>?> GetAllDiretores();
    }
}