
using System.Text.Json.Serialization;

namespace app.Models.Dtos.Diretores
{
    public class DiretoresDto
    {
        [JsonPropertyName("Diretores")]
        public required string NomeDiretor { get; set; }
    }
}