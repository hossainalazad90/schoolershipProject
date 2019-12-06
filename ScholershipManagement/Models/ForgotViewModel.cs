using System.ComponentModel.DataAnnotations;

namespace ScholershipManagement.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
