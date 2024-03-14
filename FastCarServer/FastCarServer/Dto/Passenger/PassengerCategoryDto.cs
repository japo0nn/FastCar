using FastCarServer.Dto.CarAbstract;

namespace FastCarServer.Dto.Passenger
{
    public class PassengerCategoryDto : CategoryDto
    { 
        public Guid BrandId { get; set; }
        public PassengerBrandDto Brand { get; set; }
    }
}
