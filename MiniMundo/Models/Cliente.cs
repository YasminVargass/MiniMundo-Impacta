using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Sobrenome")]
        public string? Sobrenome { get; set; }

        [StringLength(11,MinimumLength =11,ErrorMessage = "Digita apenas números.")]
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
        [Display(Name = "Endereço")]
        public string? Endereço { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Número")]
        public int Número { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Bairro")]
        public string? Bairro { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Cidade")]
        public string? Cidade { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Estado")]
        public string? Estado { get; set; }

        [Display(Name = "Nível de Acesso")]
        public int NivelAcessoID { get; set; }
    }
}
