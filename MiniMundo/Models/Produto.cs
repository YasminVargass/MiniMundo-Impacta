using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoID { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Estoque Atual")]
        public int EstoqueAtual { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Estoque Mínimo")]
        public int MinEstoque { get; set; }


        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Categoria")]
        public int CategoriaID { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Fornecedor")]
        public int FornecedorID { get; set; }
    }
}