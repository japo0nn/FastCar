using FastCarServer.Core.Data.Abstract;

namespace FastCarServer.Core.Data.Passenger
{
    public class PassengerBrandModel : Entity
    {
        public string Name { get; set; }

        public Guid BrandYearId { get; set; }
        public PassengerBrandYear BrandYear { get; set; }
    }
}
