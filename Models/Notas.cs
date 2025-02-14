using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Notas")]
    public class Notas
    {
        [Column("Id")]
        [Display(Name = "Id Notas")]
        public int Id { get; set; }


        [ForeignKey("TituloMaterias")]
        [Display(Name = "Materia")]
        public int MateriasId { get; set; }
        public Materias? Materias { get; set; }


        [ForeignKey("Alunos")]
        [Display(Name = "Alunos")]
        public int AlunosId { get; set; }
        public Alunos? Alunos
        { get; set; }


        [ForeignKey("Etapas")]
        [Display(Name = "Etapas")]
        public int EtapasId { get; set; }
        public Etapas? Etapas
        { get; set; }


        [Column("Nota")]
        [Display(Name = "Nota")]
        public Double Nota { get; set; }



    }
}
