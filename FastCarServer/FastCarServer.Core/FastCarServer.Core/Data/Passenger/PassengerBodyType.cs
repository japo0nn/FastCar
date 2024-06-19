using FastCarServer.Core.Data.Abstract;

namespace FastCarServer.Core.Data.Passenger
{
    public class PassengerBodyType : Entity
    {
        public string Name { get; set; }

        public Guid GenerationId { get; set; }
        public PassengerGeneration Generation { get; set; }
    }
}
