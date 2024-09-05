using app.Models.Dtos.Diretores;
using app.Repository;
using app.Services;
using Moq;

namespace App.Tests.Services
{
    public class DiretoresServiceTeste
    {
        private readonly Mock<IFilmesRespository> _mockRepository;
        private readonly IDiretoresService _iDiretoresService;

        public DiretoresServiceTeste()
        {
            _mockRepository = new Mock<IFilmesRespository>();

            _iDiretoresService = new DiretoresService(_mockRepository.Object);
        }

        [Fact]
        public async void ShouldReturnListOfDiretores()
        {
            //Arrange(Give)
            var DiretoresDtoFake = new List<DiretoresDto>
            {
                new()
                {
                    NomeDiretor = "Nome diretor Teste"
                },
                new()
                {
                    NomeDiretor = "Nome diretor Teste 2"
                }
            };

            _mockRepository
            .Setup(repo => repo.GetAllDiretoresAsync())
            .ReturnsAsync(DiretoresDtoFake);

            //Act(When)
            var result = await _iDiretoresService.GetAllDiretores();

            //Assert(Then)
            Assert.NotNull(result);
            Assert.Equal(DiretoresDtoFake, result);
        }
    }
}