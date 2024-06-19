using System.ComponentModel.DataAnnotations;

namespace FastCarServer.Application.Common.Views
{
    public class LoginViewModel
    {
        [Required]
        public string PhoneNumber { get; set; }
    }
}
