using FastCarServer.Dto.Abstract;

namespace FastCarServer.Dto.Passenger
{
    public class PassengerBrandDto : MainDto
    {
        public string Name { get; set; }

        public Guid BrandModelId { get; set; }
        public PassengerBrandModelDto BrandModel { get; set; }
    }
}
