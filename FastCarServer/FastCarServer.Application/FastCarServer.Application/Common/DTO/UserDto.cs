using FastCarServer.Application.Common.DTO.Abstract;
using Microsoft.AspNetCore.Identity;

namespace FastCarServer.Application.Common.DTO
{
    public class UserDto : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<CarDto> Cars { get; set; }
    }
}
