using app.Models;

namespace App.Tests.Mocks
{
    internal class MockFilmesRepository
    {
        public static List<Filmes> FilmesMock()
        {
            var fakeFilmes = new List<Filmes>(){
               new() {
                    IdFilme = 1,
                    NomeFilme = "Teste 1",
                    DataLancamento = new DateTime(2010, 7, 16),
                    Descricao = "Teste descrição 1",
                    IdGenero = 1,
                    IdDiretor = 1,
                },
                new() {
                    IdFilme = 2,
                    NomeFilme = "Teste 2",
                    DataLancamento = new DateTime(2011, 7, 16),
                    Descricao = "Teste descrição 2",
                    IdGenero = 2,
                    IdDiretor = 2,
                  }
            };
            return fakeFilmes;
        }

        public static List<Diretores> DiretoresMock()
        {
            var DiretoresFake = new List<Diretores>
             {
                 new()
                 {
                    IdDiretor = 1,
                    NomeDiretor = "Nome diretor Teste"
                 },
                 new()
                 {
                    IdDiretor = 2,
                    NomeDiretor = "Nome diretor Teste 2"
                 }
             };

            return DiretoresFake;
        }

        public static List<Generos> GenerosMock()
        {
            var GenerosFake = new List<Generos>
            {
                new(){
                    IdGenero = 1,
                    TipoDoGenero = "Tipo do genero 1",
                },
                new(){
                    IdGenero = 2,
                    TipoDoGenero = "Tipo do genero 2",
                }
            };

            return GenerosFake;
        }
    }
}