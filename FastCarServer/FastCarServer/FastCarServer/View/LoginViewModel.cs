using System.ComponentModel.DataAnnotations;

namespace FastCarServer.View
{
    public class LoginViewModel
    {
        [Required]
        public string PhoneNumber { get; set; }
    }
}
