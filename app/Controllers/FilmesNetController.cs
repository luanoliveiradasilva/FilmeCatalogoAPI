using app.Services;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class FilmesNetController(IFilmesNetServices iFilmesNetServices) : ControllerBase
    {

        private readonly IFilmesNetServices _filmesNetServices = iFilmesNetServices;

        [HttpGet]
        public async Task<ActionResult> GetFilmes() => Ok(await _filmesNetServices.GetFilmes());

        [HttpGet("Movies")]
        public async Task<ActionResult> GetFilmes(int pageNumber = 1, int pageSize = 10) => Ok(await _filmesNetServices.GetFilmesAllDatas(pageNumber, pageSize));

    }
}