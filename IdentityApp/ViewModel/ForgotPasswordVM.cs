using System.ComponentModel.DataAnnotations;

namespace IdentityApp.ViewModel
{
    public class ForgotPasswordVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
