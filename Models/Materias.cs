using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Materias")]
    public class Materias
    {
        [Column("Id")]
        [Display(Name = "Id Matéria")]
        public int Id { get; set; }

        [Column("Materia")]
        [Display(Name = "Titulo Matéria")]
        public string Titulo { get; set; } = string.Empty;

        [ForeignKey("Id")]
        [Display(Name = "Professores")]
        public int ProfessoresId { get; set; }
        public Professores? Professores { get; set; }

    }
}
