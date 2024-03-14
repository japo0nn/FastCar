using FastCarServer.Dto.Abstract;

namespace FastCarServer.Dto.Passenger
{
    public class PassengerBrandYearDto : MainDto
    {
        public int Year { get; set; }

        public Guid BodyTypeId { get; set; }
        public PassengerBodyTypeDto BodyType { get; set; }
    }
}
