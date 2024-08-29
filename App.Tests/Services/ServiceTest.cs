using app.Services;
using Moq;
using app.Repository;
using AutoFixture;
using app.Models.DTO;

namespace App.Test.Services;
public class ServiceTest
{

    private readonly IFilmesNetServices _filmesNetServices;
    private readonly Mock<IFilmesRespository> _filmesRepositoryMock;
    private readonly Fixture _fixture;

    public ServiceTest()
    {
        _filmesRepositoryMock = new Mock<IFilmesRespository>();

        _fixture = new Fixture();

        _filmesNetServices = new FilmesNetServices(_filmesRepositoryMock.Object);
    }

    [Fact]
    public void GetFilmes_ShouldReturnListOfFilmes()
    {
        // Arrange (Given)
        var filmesDTOFake = _fixture.CreateMany<FilmesDTO>(5).ToList();

        _filmesRepositoryMock
        .Setup(repo => repo.GetFilmesAsync(It.IsAny<int>(), It.IsAny<int>()))
        .ReturnsAsync(filmesDTOFake);

        // Act (When)
        var result = _filmesNetServices.GetFilmes(1, 5).Result;

        // Assert (Then)
        Assert.NotNull(result);
        Assert.Equal(filmesDTOFake.Count, result.Count());
    }
}