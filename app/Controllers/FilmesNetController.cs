using app.Services;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class FilmesNetController(
        IFilmesNetServices iFilmesNetServices,
        IDiretoresService iDiretoresService,
        IGenerosServices iGenerosServices
        ) : ControllerBase
    {

        private readonly IFilmesNetServices _filmesNetServices = iFilmesNetServices;

        private readonly IDiretoresService _diretoresService = iDiretoresService;

        private readonly IGenerosServices _generosService = iGenerosServices;

     /*    [HttpGet("filmes ")]
        public async Task<ActionResult> GetFilmes() => Ok(await _filmesNetServices.GetFilmes()); */

        /*[HttpGet("Movies")]
        public async Task<ActionResult> GetFilmes(int pageNumber = 1, int pageSize = 10) => Ok(await _filmesNetServices.GetFilmesAllDatas(pageNumber, pageSize));

        [HttpGet("Diretores")]
        public async Task<ActionResult> GetAllDiretores() => Ok(await _diretoresService.GetAllDiretores());

        [HttpGet("Generos")]
        public async Task<ActionResult> GetAllGeneros() => Ok(await _generosService.GetAllGeneros()); */

    }
}