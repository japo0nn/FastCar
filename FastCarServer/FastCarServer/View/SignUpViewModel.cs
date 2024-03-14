using System.ComponentModel.DataAnnotations;

namespace FastCarServer.View
{
    public class SignUpViewModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
