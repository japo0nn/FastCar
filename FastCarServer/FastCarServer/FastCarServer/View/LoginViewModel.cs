using System.ComponentModel.DataAnnotations;

namespace FastCarServer.WebAPI.View
{
    public class LoginViewModel
    {
        [Required]
        public string PhoneNumber { get; set; }
    }
}
