using app.Models;
using app.Repository;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmesNetController(IFilmesRespository repository) : ControllerBase
    {
        private readonly IFilmesRespository _repository = repository;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Filmes>>> GetFilmes() => Ok(await _repository.GetFilmesAsync());

    }
}