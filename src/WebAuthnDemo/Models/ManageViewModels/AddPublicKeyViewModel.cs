using System.ComponentModel.DataAnnotations;

namespace WebAuthnDemo.Models.ManageViewModels
{
    public class AddPublicKeyViewModel
    {
        [Required]
        public string PublicKey { get; set; }
    }
}
