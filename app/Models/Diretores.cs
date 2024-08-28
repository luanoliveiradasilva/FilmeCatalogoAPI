using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    [Table("diretores")]
    public class Diretores
    {
        [Key]
        [Column("id_diretor")]
        public int IdDiretor { get; set; }

        [Column("nome_diretor")]
        public required string NomeDiretor { get; set; }

    }
}