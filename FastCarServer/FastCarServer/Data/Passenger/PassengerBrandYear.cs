using FastCarServer.Data.Abstract;

namespace FastCarServer.Data.Passenger
{
    public class PassengerBrandYear : Entity
    {
        public int Year { get; set; }

        public Guid BodyTypeId { get; set; }
        public PassengerBodyType BodyType { get; set; }
    }
}
