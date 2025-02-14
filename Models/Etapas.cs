using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    [Table("Etapas")]
    public class Etapas
    {
        [Column("Id")]
        [Display(Name = "Id Matéria")]
        public int Id { get; set; }

        [Column("Titulo")]
        [Display(Name = "Titulo Matéria")]
        public string Titulo { get; set; } = string.Empty;

        [Column("Ano")]
        [Display(Name = "Ano")]
        public string Ano { get; set; } = string.Empty;
    }
}
