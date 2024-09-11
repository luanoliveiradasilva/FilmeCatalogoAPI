using app.Controllers;
using app.Models;
using app.Models.Dtos.Filmes;
using app.Services;
using App.Tests.Mocks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace App.Tests.Controller
{
    public class FilmesNetControllerTest
    {
        private readonly Mock<IFilmesNetServices> _mockFilmesServices;
        private readonly Mock<IDiretoresService> _mockDiretoresServices;
        private readonly Mock<IGenerosServices> _mockGenerosServices;
        private readonly FilmesNetController _filmesNetController;

        public FilmesNetControllerTest()
        {
            _mockFilmesServices = new Mock<IFilmesNetServices>();
            _mockDiretoresServices = new Mock<IDiretoresService>();
            _mockGenerosServices = new Mock<IGenerosServices>();

            _filmesNetController = new FilmesNetController(
                _mockFilmesServices.Object,
                _mockDiretoresServices.Object,
                _mockGenerosServices.Object
            );
        }

        [Fact]
        public async void ShouldGetReturn200Ok()
        {
            //Arrange
            var mockMovies = MockFilmesRepository.FilmesMock();

            _mockFilmesServices
            .Setup(s => s.GetAllMovies())
            .ReturnsAsync(mockMovies);

            //Act
            var result = await _filmesNetController.GetFilmes();

            //Asset
            Assert.True(result is OkObjectResult);
        }

        [Fact]
        public async void GetFilmesReturnsFilmesWithDto()
        {
            // Arrange
            var mockMovies = MockFilmesRepository.FilmesMock();

            var mockDtos = mockMovies.Select(f => new FilmesDto
            {
                NomeFilme = f.NomeFilme,
                DataLancamento = f.DataLancamento,
                Descricao = f.Descricao
            }).ToList();

            _mockFilmesServices
                .Setup(s => s.GetAllMovies())
                .ReturnsAsync(mockMovies);

            // Act
            var result = await _filmesNetController.GetFilmes();

            // Assert
            var actualResponse = Assert.IsType<OkObjectResult>(result);
            var actualDtos = Assert.IsAssignableFrom<IEnumerable<FilmesDto>>(actualResponse.Value);

            Assert.Equal(mockDtos.Count, actualDtos.Count());
            Assert.Equal(mockDtos.First().NomeFilme, actualDtos.First().NomeFilme);
        }

        [Fact]
        public async Task ShouldGetAllFilmesNotFound()
        {
            //Arrange
            _mockFilmesServices
           .Setup(s => s.GetAllMovies())
           .Returns(Task.FromResult((IEnumerable<Filmes>?)null));

            //Act
            var result = await _filmesNetController.GetFilmes();

            // act Assert
            Assert.True(result is NotFoundResult);
        }

        [Fact]
        public async void ShouldGetAllDiretores()
        {
            //Arrange
            var mockDiretores = MockFilmesRepository.DiretoresMock();

            _mockDiretoresServices
            .Setup(s => s.GetAllDiretores())
            .ReturnsAsync(mockDiretores);

            //Act
            var result = await _filmesNetController.GetAllDiretores();

            //Assert
            Assert.True(result is OkObjectResult);
        }

        [Fact]
        public async Task ShouldGetAllDiretoresNotFound()
        {
            //Arrange
            _mockDiretoresServices
           .Setup(s => s.GetAllDiretores())
           .Returns(Task.FromResult((IEnumerable<Diretores>?)null));

            //Act
            var result = await _filmesNetController.GetAllDiretores();

            // act Assert
            Assert.True(result is NotFoundResult);
        }

        [Fact]
        public async void ShouldGetAllGeneros()
        {
            //Arrange
            var mockGenero = MockFilmesRepository.GenerosMock();

            _mockGenerosServices
            .Setup(s => s.GetAllGeneros())
            .ReturnsAsync(mockGenero);

            //Act
            var result = await _filmesNetController.GetAllGeneros();

            //Assert
            Assert.True(result is OkObjectResult);
        }

        [Fact]
        public async Task ShouldGetAllGenerosNotFound()
        {
            //Arrange
            _mockGenerosServices
           .Setup(s => s.GetAllGeneros())
           .Returns(Task.FromResult((IEnumerable<Generos>?)null));

            //Act
            var result = await _filmesNetController.GetAllGeneros();

            // act Assert
            Assert.True(result is NotFoundResult);
        }
    }
}