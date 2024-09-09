using app.Services;
using Moq;
using app.Repository;
using app.Models.Dtos.Filmes;
using App.Tests.Mocks;

namespace App.Test.Services;
public class FilmesServiceTest
{/* 
    private readonly Mock<IFilmesRepository> _filmesRepositoryMock;
    private readonly IFilmesNetServices _filmesNetServices;

    public FilmesServiceTest()
    {
        _filmesRepositoryMock = new Mock<IFilmesRepository>();

        _filmesNetServices = new FilmesNetServices(_filmesRepositoryMock.Object);
    }

    [Fact]
    public async void GetMoviesShouldReturnListOfFilmes()
    {
        //Arrange(Give)
        var filmeTest = MockIFilmesRepository.GetFilmes();

        _filmesRepositoryMock
        .Setup(mockRepo => mockRepo.GetFilmesAsync())
        .ReturnsAsync(() => filmeTest);

        //Act (When)
        var result = await _filmesNetServices.GetFilmes();

        //Assert(Then)
        Assert.NotNull(result);
        Assert.Equal(filmeTest, result);

    }

    [Fact]
    public async void GetFilmesShouldReturnListOfFilmes()
    {
        int pageNumber = 1;
        int pageSize = 10;

        //Arrange(Give)
        var FilmesDTOFake = new List<FilmesAllDTO>
        {
            new(){
                NomeFilme  = "Inception",
                DataLancamento = new DateTime(2010, 7, 16),
                Descricao = "Um ladrão que rouba segredos corporativos...",
                TipoDoGenero = "Teste Tipo genero",
                NomeDiretor = "Teste nome diretor",
            },
            new(){
                NomeFilme  = "Inception",
                DataLancamento = new DateTime(2010, 7, 16),
                Descricao = "Um ladrão que rouba segredos corporativos...",
                TipoDoGenero = "Teste Tipo genero",
                NomeDiretor = "Teste nome diretor",
            },
        };


        _filmesRepositoryMock
        .Setup(repo => repo.GetFilmesAllDatasAsync(pageNumber, pageSize))
        .ReturnsAsync(FilmesDTOFake);

        //Act(When)
        var result = await _filmesNetServices.GetFilmesAllDatas(pageNumber, pageSize);

        //Assert(Then)
        Assert.NotNull(result);
        Assert.Equal(FilmesDTOFake, result);
    }
 */}