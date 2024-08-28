using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    [Table("filmes")]
    public class Filmes
    {
        [Key]
        [Column("id_filme")]
        public int IdFilme { get; set; }

        [Column("nome_filme")]
        public required string NomeFilme { get; set; }

        [Column("data_alancamento")]
        public DateTime DataLancamento { get; set; }

        [Column("descricao")]
        public required string Descricao { get; set; }

        [Column("id_genero")]
        public required int IdGenero { get; set; }

        [Column("id_diretor")]
        public required int IdDiretor { get; set; }
    }
}