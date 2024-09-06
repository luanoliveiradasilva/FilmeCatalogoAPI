using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Models.Dtos.Generos;
using app.Repository;
using app.Services;
using Microsoft.AspNetCore.Builder;
using Moq;
using Xunit;

namespace App.Tests.Services
{
    public class GenerosServiceTest
    {

        private readonly Mock<IFilmesRespository> _filmesRepositoryMock;

        private readonly IGenerosServices _iGeneroServices;

        public GenerosServiceTest()
        {
            _filmesRepositoryMock = new Mock<IFilmesRespository>();
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
}