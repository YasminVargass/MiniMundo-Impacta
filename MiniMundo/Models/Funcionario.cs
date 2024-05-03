using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioID { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name ="Nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Sobrenome")]
        public string? Sobrenome { get; set; }


        [StringLength(11, MinimumLength = 11, ErrorMessage = "Digite apenas números.")]
        [Display(Name = "CPF")]
        public string? CPF { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "Senha deve ter entre 4 e 15 caracteres.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string? Senha { get; set; }

        [Display(Name = "Confirmar Senha")]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "As senhas precisam ser idênticas.")]
        public string? ConfirmarSenha { get; set; }


        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Cargo")]
        public string? Cargo { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Salário")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Nível de Acesso")]
        public int NivelAcessoID { get; set; }

    }
}
