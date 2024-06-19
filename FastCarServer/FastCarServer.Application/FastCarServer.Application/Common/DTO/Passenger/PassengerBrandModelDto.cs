using FastCarServer.Application.Common.DTO.Abstract;

namespace FastCarServer.Application.Common.DTO.Passenger
{
    public class PassengerBrandModelDto : MainDto
    {
        public string Name { get; set; }

        public Guid BrandYearId { get; set; }
        public PassengerBrandYearDto BrandYear { get; set; }
    }
}
