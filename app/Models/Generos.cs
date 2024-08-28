using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.Models
{
    [Table("generos")]
    public class Generos
    {
        [Key]
        [Column("id_genero")]
        public int IdGenero { get; set; }

        [Column("tipo_do_genero")]
        public required string TipoDoGenero { get; set; }
    }
}