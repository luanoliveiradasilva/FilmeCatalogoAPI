using app.Models;
using app.Models.Dtos.Filmes;
using app.Repository;
using Moq;

namespace App.Tests.Mocks
{
    internal class MockIFilmesRepository
    {
       /*  public static Mock<IFilmesRepository> GetMock()
        {
            var mock = new Mock<IFilmesRepository>();

            var filmes = GetFilmes();

            mock
            .Setup(mockRepo => mockRepo.GetFilmesAsync())
            .ReturnsAsync(() => filmes);

            return mock;
        } */

        public static List<FilmesDto> GetFilmes()
        {
            var fakeFilmes = new List<FilmesDto>(){
               new() {
                    NomeFilme = "Inception",
                    DataLancamento = new DateTime(2010, 7, 16),
                    Descricao = "Um ladrão que rouba segredos corporativos..."
                },
                new() {
                    NomeFilme = "The Matrix",
                    DataLancamento = new DateTime(1999, 3, 31),
                    Descricao = "Um hacker aprende sobre a verdadeira natureza de sua realidade..." }
            };
            return fakeFilmes;
        }
    }
}