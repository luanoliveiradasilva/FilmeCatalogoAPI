using app.Models.DTO;

namespace app.Services
{
    public interface IFilmesNetServices
    {
        Task<IEnumerable<FilmesDTO>> GetFilmes(int pageNumber, int pageSize);
    }
}