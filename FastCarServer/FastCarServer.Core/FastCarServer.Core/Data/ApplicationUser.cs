using FastCarServer.Core.Data.Abstract;
using FastCarServer.Core.Enums;
using Microsoft.AspNetCore.Identity;

namespace FastCarServer.Core.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public VerificationType Verification { get; set; }

        public List<Car> Cars { get; set; }
    }
}
