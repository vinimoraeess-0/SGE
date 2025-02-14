using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGE.Models
{
    [Table("Alunos")]
    public class Alunos
    {
        [Column("Id")]
        [Display(Name = "Id Alunos")]
        public int Id { get; set; }

        [Column("NomeAluno")]
        [Display(Name = "Nome do Aluno")]
        public string NomeAluno { get; set; } = string.Empty;

        [Column("CpfAluno")]
        [Display(Name = "Cpf do Aluno")]
        public string Cpf { get; set; } =string.Empty;

        [Column("EmailAluno")]
        [Display(Name = "Email do Aluno")]
        public string Email { get; set; } = string.Empty ;

        [Column("TelAluno")]
        [Display(Name = "Telefone do Aluno")]
        public string Telefone { get; set; } = string.Empty;

        [Column("NascimentoAluno")]
        [Display(Name = "Data de nascimento do Aluno")]
        public string Nascimento { get; set; } = string.Empty;


    }
}
