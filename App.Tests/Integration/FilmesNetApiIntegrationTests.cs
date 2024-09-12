
using Microsoft.AspNetCore.Mvc.Testing;

namespace App.Tests.Integration
{
    public class FilmesNetApiIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
    {
        private readonly CustomWebApplicationFactory<Program> _factory;

        public FilmesNetApiIntegrationTests()
        {
            _factory = new CustomWebApplicationFactory<Program>();
        }

        [Fact]
        public async Task Get_EndpointsReturnSuccess()
        {
            // Arrange
            string url = "api/FilmesNet/v1/filmes";

            var client = _factory.CreateClient();

            //Act
            var response = await client.GetAsync(url);


            //Assert

        }
    }
}