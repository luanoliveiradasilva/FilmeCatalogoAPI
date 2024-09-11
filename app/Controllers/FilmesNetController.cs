using app.Models;
using app.Models.Dtos.Diretores;
using app.Models.Dtos.Filmes;
using app.Models.Dtos.Generos;
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

            if (getRequest is null)
                return NotFound();

            var response = getRequest.Select(dir => new DiretoresDto
            {
                NomeDiretor = dir.NomeDiretor
            });

            return Ok(response);
        }

        [HttpGet("Generos")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Generos>))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetAllGeneros()
        {
            var getRequest = await _generosService.GetAllGeneros();

            if (getRequest is null)
                return NotFound();

            var response = getRequest.Select(ger => new GenerosDto
            {
                TipoDoGenero = ger.TipoDoGenero
            });

            return Ok(response);
        }
    }
}