using app.Models.Dtos.Diretores;
using app.Models.Dtos.Filmes;
using app.Models.Dtos.Generos;

namespace app.Repository
{
    public interface IFilmesRespository
    {
        Task<IEnumerable<FilmesDto>> GetFilmesAsync();
        Task<IEnumerable<FilmesAllDTO>> GetFilmesAllDatasAsync(int pageNumber, int pageSize);
        Task<IEnumerable<DiretoresDto>> GetAllDiretoresAsync();
        Task<IEnumerable<GenerosDto>> GetAllGenerosAsync();

    }
}