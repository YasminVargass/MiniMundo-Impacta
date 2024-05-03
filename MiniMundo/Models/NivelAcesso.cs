using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class NivelAcesso
    {
        [Required]
        [Key]
        public int NivelID { get; set; }

        [Required]
        [Display(Name = "Nível de Acesso")]
        public string? CategoriaAcesso { get; set; }


    }
}
