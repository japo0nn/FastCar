using FastCarServer.Core.Data.Abstract;

namespace FastCarServer.Core.Data.Passenger
{
    public class PassengerBrandYear : Entity
    {
        public int Year { get; set; }

        public Guid BodyTypeId { get; set; }
        public PassengerBodyType BodyType { get; set; }
    }
}
