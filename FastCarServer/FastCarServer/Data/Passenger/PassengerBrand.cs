using FastCarServer.Data.Abstract;

namespace FastCarServer.Data.Passenger
{
    public class PassengerBrand : Entity
    {
        public string Name { get; set; }

        public Guid BrandModelId { get; set; }
        public PassengerBrandModel BrandModel { get; set; }
    }
}
