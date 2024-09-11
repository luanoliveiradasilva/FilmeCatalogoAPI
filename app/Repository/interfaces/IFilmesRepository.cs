using app.Models;

namespace app.Repository
{
    public interface IFilmesRepository
    {
        Task<IEnumerable<Filmes>> GetAllFilmes();
        Task<IEnumerable<Diretores>> GetAllDiretores();
        Task<IEnumerable<Generos>> GetAllGeneros();

    }
}