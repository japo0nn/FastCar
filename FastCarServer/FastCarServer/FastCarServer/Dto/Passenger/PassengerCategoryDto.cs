using FastCarServer.WebAPI.Dto.CarAbstract;

namespace FastCarServer.WebAPI.Dto.Passenger
{
    public class PassengerCategoryDto : CategoryDto
    {
        public Guid BrandId { get; set; }
        public PassengerBrandDto Brand { get; set; }
    }
}
