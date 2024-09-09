using app.Infrastructure;
using app.Models;
using app.Repository;
using Microsoft.EntityFrameworkCore;

namespace App.Tests.Repository
{
    public class FilmesRepositoryTest
    {
        private readonly FilmesNetDbContext _filmesNetDbContext;

        public FilmesRepositoryTest()
        {
            DbContextOptionsBuilder dbOptions = new DbContextOptionsBuilder().UseInMemoryDatabase(Guid.NewGuid().ToString());

            _filmesNetDbContext = new FilmesNetDbContext(dbOptions.Options);
        }
        [Fact]
        public async void ShouldReturnAllFilmes()
        {
            //Arrange 
            var filmesFake = new List<Filmes>(){
               new()
                {
                    IdFilme = 1,
                    NomeFilme = "Teste",
                    DataLancamento = new DateTime(2010, 7, 16),
                    Descricao = "Teste descricao",
                    IdGenero = 1,
                    IdDiretor = 1,
                }
            };
            _filmesNetDbContext.Filmes.AddRange(filmesFake);
            await _filmesNetDbContext.SaveChangesAsync();

            var repo = new FilmesRepository(_filmesNetDbContext);

            //Act
            IEnumerable<Filmes> result = await repo.GetAllFilmes();

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async void ShouldGetAllDiretores()
        {
            //Arrange
            var diretoresFake = new List<Diretores>()
            {
                new() { IdDiretor = 1,NomeDiretor = "Nome Diretor 1"},
                new() { IdDiretor = 2,NomeDiretor = "Nome Diretor 2"}
            };

            _filmesNetDbContext.Diretores.AddRange(diretoresFake);

            await _filmesNetDbContext.SaveChangesAsync();

            var repo = new FilmesRepository(_filmesNetDbContext);

            //Act
            IEnumerable<Diretores> result = await repo.GetAllDiretores();

            //Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async void ShouldGetAllGeneros()
        {
            //Arrange
            var generosFake = new List<Generos>()
            {
                new(){ IdGenero = 1, TipoDoGenero="Tipo de generos 1"},
                new(){ IdGenero = 2, TipoDoGenero="Tipo de generos 2"}
            };

            _filmesNetDbContext.Generos.AddRange(generosFake);

            await _filmesNetDbContext.SaveChangesAsync();

            var repo = new FilmesRepository(_filmesNetDbContext);

            //Act
            IEnumerable<Generos> result = await repo.GetAllGeneros();

            //Assert
            Assert.NotNull(result);

        }
    }
}