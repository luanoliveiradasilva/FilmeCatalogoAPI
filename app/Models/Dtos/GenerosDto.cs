using System.Text.Json.Serialization;

namespace app.Models.Dtos.Generos
{
    public class GenerosDto
    {
        [JsonPropertyName("Genero do Filme")]
        public required string TipoDoGenero { get; set; }
    }
}