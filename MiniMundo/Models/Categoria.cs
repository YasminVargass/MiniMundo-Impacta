using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class Categoria
    {
        [Required]
        [Key]
        public int CategoriaID { get; set; }

        [Required]
        [Display(Name = "Categoria")]

        public string? Nome { get; set; }

    }
}
