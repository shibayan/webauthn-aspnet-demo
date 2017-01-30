using System.ComponentModel.DataAnnotations;

namespace WebAuthnDemo.Models.AccountViewModels
{
    public class WindowsHelloViewModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Signature { get; set; }

        [Required]
        public string AuthenticatorData { get; set; }

        [Required]
        public string ClientData { get; set; }
    }
}
