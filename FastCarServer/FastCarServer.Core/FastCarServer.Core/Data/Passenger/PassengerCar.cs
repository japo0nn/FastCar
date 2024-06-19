using FastCarServer.Core.Data.Abstract;

namespace FastCarServer.Core.Data.Passenger
{
    public class PassengerCar : Car
    {
        public Guid CategoryId { get; set; }
        public PassengerCategory Category { get; set; }

        public Guid BrandId { get; set; }
        public PassengerBrand Brand { get; set; }

        public Guid ModelId { get; set; }
        public PassengerBrandModel Model { get; set; }

        public Guid YearId { get; set; }
        public PassengerBrandYear Year { get; set; }

        public Guid BodyTypeId { get; set; }
        public PassengerBodyType BodyType { get; set; }

        public Guid GenerationId { get; set; }
        public PassengerGeneration Generation { get; set; }
    }
}
