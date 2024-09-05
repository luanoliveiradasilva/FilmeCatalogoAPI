using app.Services;
using Moq;
using app.Repository;
using app.Models.Dtos.Filmes;

namespace App.Test.Services;
public class ServiceTest
{

    private readonly IFilmesNetServices _filmesNetServices;
    private readonly Mock<IFilmesRespository> _filmesRepositoryMock;

    public ServiceTest()
    {
        _filmesRepositoryMock = new Mock<IFilmesRespository>();

        _filmesNetServices = new FilmesNetServices(_filmesRepositoryMock.Object);
    }

    [Fact]
    public async void GetMoviesShouldReturnListOfFilmes()
    {
        //Arrange(Give)
        var FilmesDTOFake = new List<FilmesDto>
        {
            new() {
                NomeFilme = "Inception",
                DataLancamento = new DateTime(2010, 7, 16),
                Descricao = "Um ladrão que rouba segredos corporativos..."
            },
            new() {
                NomeFilme = "The Matrix",
                DataLancamento = new DateTime(1999, 3, 31),
                Descricao = "Um hacker aprende sobre a verdadeira natureza de sua realidade..." },
        };

        _filmesRepositoryMock
        .Setup(repo => repo.GetFilmesAsync())
        .ReturnsAsync(FilmesDTOFake);

        //Act (When)
        var result = await _filmesNetServices.GetFilmes();

        //Assert(Then)
        Assert.NotNull(result);
        Assert.Equal(FilmesDTOFake, result);

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
}