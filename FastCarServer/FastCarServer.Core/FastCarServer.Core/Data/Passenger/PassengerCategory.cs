using FastCarServer.Core.Data.Abstract;
using FastCarServer.Core.Data.CarAbstract;

namespace FastCarServer.Core.Data.Passenger
{
    public class PassengerCategory : Category
    {
        public Guid BrandId { get; set; }
        public PassengerBrand Brand { get; set; }

        public PassengerCategory()
        {
            this.Name = "Легковые машины";
        }
    }
}
