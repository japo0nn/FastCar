using FastCarServer.Application.Common.DTO.CarAbstract;

namespace FastCarServer.Application.Common.DTO.Passenger
{
    public class PassengerCategoryDto : CategoryDto
    {
        public Guid BrandId { get; set; }
        public PassengerBrandDto Brand { get; set; }
    }
}
