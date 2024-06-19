using FastCarServer.WebAPI.Dto.Abstract;

namespace FastCarServer.WebAPI.Dto.Passenger
{
    public class PassengerBrandYearDto : MainDto
    {
        public int Year { get; set; }

        public Guid BodyTypeId { get; set; }
        public PassengerBodyTypeDto BodyType { get; set; }
    }
}
