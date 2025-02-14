using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGE.Models
{
    [Table("Professores")]
    public class Professores
    {
        [Column("Id")]
        [Display(Name = "ProfessoresId")]
        public int Id { get; set; }

        [Column("NomeProfessor")]
        [Display(Name = "Nome")]
        public string NomeProf { get; set; } = string.Empty;

        [Column("CpfProfessor")]
        [Display(Name = "Cpf")]
        public string Cpf { get; set; } = string.Empty;

        [Column("EmailProfessor")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [Column("TelProfessor")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; } = string.Empty;

        [Column("NascimentoProfessor")]
        [Display(Name = "Data de nascimento")]
        public string Nascimento { get; set; } = string.Empty;
    }
}
