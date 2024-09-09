using app.Repository;
using app.Services;
using App.Tests.Mocks;
using Moq;

namespace App.Tests.Services
{
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
        public async void ShouldReturnAllGeneros()
        {
            //Arrange
            var generoMock = MockFilmesRepository.GenerosMock();

            _filmesRepositoryMock
            .Setup(repoMock => repoMock.GetAllGeneros())
            .ReturnsAsync(generoMock);

            //Act
            var result = await _iGeneroServices.GetAllGeneros();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(generoMock, result);

        }

        [Fact]
        public async void ShouldReturnGenerosException()
        {
            //Arrange
            _filmesRepositoryMock
            .Setup(repoMock => repoMock.GetAllGeneros())
            .ThrowsAsync(new Exception("Simulated exception"));

            //Act
            var exception = await Assert.ThrowsAsync<Exception>(() => _iGeneroServices.GetAllGeneros());

            //Assert
            Assert.Equal("Error not found", exception.Message);
        }
    }
}