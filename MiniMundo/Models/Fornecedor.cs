using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class Fornecedor
    {
        [Required]
        [Key]
        public int FornecedorID { get; set; }


        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Nome")] 
        public string? Nome { get; set; }


        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "Digita apenas números.")]
        [Display(Name = "CNPJ")]
        public string? CNPJ { get; set; }


        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Categoria")] 
        public int CategoriaID { get; set; }


        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Nível de Acesso")]
        public int NivelAcessoID { get; set; }
    }
}
