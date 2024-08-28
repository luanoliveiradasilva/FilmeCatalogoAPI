using app.Services;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesNetController(IFilmesNetServices iFilmesNetServices) : ControllerBase
    {

        private readonly IFilmesNetServices _filmesNetServices = iFilmesNetServices;


        /*      [HttpGet]
             public async Task<ActionResult<IEnumerable<Filmes>>> GetFilmes() => Ok(await _repository.GetFilmesAsync()); */

        [HttpGet]
        public async Task<ActionResult> GetFilmes(int pageNumber = 1, int pageSize = 10) => Ok(await _filmesNetServices.GetFilmes(pageNumber, pageSize));

    }
}