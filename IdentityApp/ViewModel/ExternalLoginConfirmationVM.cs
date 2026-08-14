using System.ComponentModel.DataAnnotations;

namespace IdentityApp.ViewModel
{
    public class ExternalLoginConfirmationVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
