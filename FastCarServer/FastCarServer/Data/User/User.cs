using FastCarServer.Data.Abstract;
using FastCarServer.Enums;
using Microsoft.AspNetCore.Identity;

namespace FastCarServer.Data.User
{
    public class User : Entity
    {
        public IdentityUser IdentityUser { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public VerificationType Verification {  get; set; }

        public List<Car> Cars { get; set; }
    }
}
