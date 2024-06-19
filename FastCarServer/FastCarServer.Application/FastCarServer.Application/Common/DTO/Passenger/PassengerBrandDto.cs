using FastCarServer.Application.Common.DTO.Abstract;

namespace FastCarServer.Application.Common.DTO.Passenger
{
    public class PassengerBrandDto : MainDto
    {
        public string Name { get; set; }

        public Guid BrandModelId { get; set; }
        public PassengerBrandModelDto BrandModel { get; set; }
    }
}
