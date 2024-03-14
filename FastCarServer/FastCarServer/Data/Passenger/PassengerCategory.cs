using FastCarServer.Data.CarAbstract;

namespace FastCarServer.Data.Passenger
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
