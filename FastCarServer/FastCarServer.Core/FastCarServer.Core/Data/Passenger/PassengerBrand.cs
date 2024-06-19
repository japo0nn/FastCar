using FastCarServer.Core.Data.Abstract;

namespace FastCarServer.Core.Data.Passenger
{
    public class PassengerBrand : Entity
    {
        public string Name { get; set; }

        public Guid BrandModelId { get; set; }
        public PassengerBrandModel BrandModel { get; set; }
    }
}
