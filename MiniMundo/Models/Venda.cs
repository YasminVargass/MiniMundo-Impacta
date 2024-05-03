using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class Venda
    {
        [Required]
        [Key]
        public int VendaID { get; set; }

        [Required]
        [Display(Name = "Cliente")]

        public int ClienteID { get; set; }

        [Required]
        [Display(Name = "Funcionário")]

        public int FuncionarioID { get; set; }
        [Required]
        [Display(Name = "Produto")]

        public int ProdutoID { get; set; }

        [Required(ErrorMessage = "O campo não pode estar vazio")]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Required]
        [Display(Name = "Total")]
        public decimal TotalVenda { get; set; }

    }
}
