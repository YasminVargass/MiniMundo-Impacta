using System.ComponentModel.DataAnnotations;

namespace MiniMundo.Models
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

    }
}
