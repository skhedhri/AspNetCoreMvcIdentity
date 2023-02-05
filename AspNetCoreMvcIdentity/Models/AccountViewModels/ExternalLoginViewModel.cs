using System.ComponentModel.DataAnnotations;

namespace AspNetCoreMvcIdentity.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
