using app.Models;
using app.Models.Dtos.Diretores;

namespace app.Services
{
    public interface IDiretoresService
    {
        Task<IEnumerable<Diretores>> GetAllDiretores();
    }
}