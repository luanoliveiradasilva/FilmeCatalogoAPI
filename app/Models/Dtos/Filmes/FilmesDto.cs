using System.Text.Json.Serialization;

namespace app.Models.Dtos.Filmes
{
    public class FilmesDto
    {
        [JsonPropertyName("Nome do Filme")]
        public required string NomeFilme { get; set; }

        [JsonPropertyName("Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [JsonPropertyName("Descrição")]
        public required string Descricao { get; set; }
    }
}