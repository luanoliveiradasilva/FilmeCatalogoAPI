using app.Repository;
using app.Services;
using App.Tests.Mocks;
using Moq;

namespace App.Tests.Services
{
    public class DiretoresServiceTest
    {
        private readonly Mock<IFilmesRepository> _mockRepository;
        private readonly IDiretoresService _iDiretoresService;

        public DiretoresServiceTest()
        {
            _mockRepository = new Mock<IFilmesRepository>();

            _iDiretoresService = new DiretoresService(_mockRepository.Object);
        }

        [Fact]
        public async void ShouldReturListOfDiretores()
        {
            //Arrange

            var diretoresMock = MockFilmesRepository.DiretoresMock();

            _mockRepository
            .Setup(d => d.GetAllDiretores())
            .ReturnsAsync(() => diretoresMock);

            //Act
            var result = await _iDiretoresService.GetAllDiretores();

            //AssertApp.Tests/Services/DiretoresServiceTest.cs
            Assert.NotNull(result);
            Assert.Equal(diretoresMock, result);
        }

        [Fact]
        public async void ShouldReturnDiretoresException()
        {
            //Arrange
            _mockRepository.Setup(mockRepo => mockRepo.GetAllDiretores())
            .ThrowsAsync(new Exception("Simulated exception"));

            //Act
            var exception = await Assert.ThrowsAsync<Exception>(() => _iDiretoresService.GetAllDiretores());

            //Assert
            Assert.Equal("Error not found", exception.Message);
        }
    }
}