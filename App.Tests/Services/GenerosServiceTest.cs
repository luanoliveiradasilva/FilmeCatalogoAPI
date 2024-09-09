using app.Models.Dtos.Generos;
using app.Repository;
using app.Services;
using Moq;

namespace App.Tests.Services
{/* 
    public class GenerosServiceTest
    {

        private readonly Mock<IFilmesRepository> _filmesRepositoryMock;

        private readonly IGenerosServices _iGeneroServices;

        public GenerosServiceTest()
        {
            _filmesRepositoryMock = new Mock<IFilmesRepository>();
            _iGeneroServices = new GenerosServices(_filmesRepositoryMock.Object);
        }


        [Fact]
        public async void ShouldReturnAllListOfMovies()
        {
            //Arrange(Give)
            var fakeGeneros = new List<GenerosDto>
            {
                new() { TipoDoGenero = "Acão"},
                new() { TipoDoGenero = "Comédia"}
            };

            _filmesRepositoryMock
            .Setup(repo => repo.GetAllGenerosAsync())
            .ReturnsAsync(fakeGeneros);

            //Act(When)
            var result = await _iGeneroServices.GetAllGeneros();

            //Assert(Then)
            Assert.NotNull(result);
            Assert.Equal(fakeGeneros, result);
        }
    }
 */}