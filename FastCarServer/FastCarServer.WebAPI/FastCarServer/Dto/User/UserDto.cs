using FastCarServer.WebAPI.Dto;
using FastCarServer.WebAPI.Dto.Abstract;

namespace FastCarServer.WebAPI.Dto.User
{
    public class UserDto : MainDto
    {
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<CarDto> Cars { get; set; }
    }
}
