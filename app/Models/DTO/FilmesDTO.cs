using System.Text.Json.Serialization;

namespace app.Models.DTO
{
    public class FilmesDTO
    {

        [JsonPropertyName("Nome do Filme")]
        public required string NomeFilme { get; set; }

        [JsonPropertyName("Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [JsonPropertyName("Descrição")]
        public required string Descricao { get; set; }

        [JsonPropertyName("Gênero")]
        public required string TipoDoGenero { get; set; }

        [JsonPropertyName("Diretor")]
        public required string NomeDiretor { get; set; }
    }
}