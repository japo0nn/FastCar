using FastCarServer.Data.Abstract;
using System.Security.Policy;

namespace FastCarServer.Data.Passenger
{
    public class PassengerBrandModel : Entity
    {
        public string Name { get; set; }

        public Guid BrandYearId { get; set; }
        public PassengerBrandYear BrandYear { get; set; }
    }
}
