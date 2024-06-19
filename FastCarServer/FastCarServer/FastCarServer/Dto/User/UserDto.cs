using FastCarServer.Dto.Abstract;

namespace FastCarServer.Dto.User
{
    public class UserDto : MainDto
    {
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<CarDto> Cars { get; set; }
    }
}
