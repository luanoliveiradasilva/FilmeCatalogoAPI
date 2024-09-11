using app.Models;
using app.Models.Dtos.Filmes;
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
        private readonly IGenerosServices _generosService =
        iGenerosServices;

        [HttpGet("filmes")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Filmes>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetFilmes()
        {
            var getRequest = await _filmesNetServices.GetAllMovies();

            if (getRequest is null)
                return NotFound();

            var response = getRequest.Select(filmes => new FilmesDto
            {
                NomeFilme = filmes.NomeFilme,
                DataLancamento = filmes.DataLancamento,
                Descricao = filmes.Descricao
            });

            return Ok(response);
        }

        [HttpGet("Diretores")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Diretores>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetAllDiretores()
        {
            var getRequest = await _diretoresService.GetAllDiretores();

            return getRequest is null ? NotFound() : Ok(getRequest);
        }

        [HttpGet("Generos")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Generos>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetAllGeneros()
        {
            var getRequest = await _generosService.GetAllGeneros();
            return getRequest is null ? NotFound() : Ok(getRequest);
        }

        /*[HttpGet("Movies")]
        public async Task<ActionResult> GetFilmes(int pageNumber = 1, int pageSize = 10) => Ok(await _filmesNetServices.GetFilmesAllDatas(pageNumber, pageSize));

         */

    }
}