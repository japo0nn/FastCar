using FastCarServer.Application.Common.DTO;

namespace FastCarServer.Application.Common.DTO.Passenger
{
    public class PassengerCarDto : CarDto
    {
        public Guid CategoryId { get; set; }
        public PassengerCategoryDto Category { get; set; }

        public Guid BrandId { get; set; }
        public PassengerBrandDto Brand { get; set; }

        public Guid ModelId { get; set; }
        public PassengerBrandModelDto Model { get; set; }

        public Guid YearId { get; set; }
        public PassengerBrandYearDto Year { get; set; }

        public Guid BodyTypeId { get; set; }
        public PassengerBodyTypeDto BodyType { get; set; }

        public Guid GenerationId { get; set; }
        public PassengerGenerationDto Generation { get; set; }
    }
}
