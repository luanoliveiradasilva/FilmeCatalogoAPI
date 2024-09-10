using app.Models;

namespace app.Repository
{
    public interface IFilmesRepository
    {
        Task<IEnumerable<Filmes>> GetAllFilmes();
        Task<IEnumerable<Diretores>> GetAllDiretores();
        Task<IEnumerable<Generos>> GetAllGeneros();
        /*         Task<IEnumerable<FilmesDto>> GetFilmesAsync();
                Task<IEnumerable<FilmesAllDTO>> GetFilmesAllDatasAsync(int pageNumber, int pageSize);
                Task<IEnumerable<DiretoresDto>> GetAllDiretoresAsync();
                Task<IEnumerable<GenerosDto>> GetAllGenerosAsync(); */

    }
}