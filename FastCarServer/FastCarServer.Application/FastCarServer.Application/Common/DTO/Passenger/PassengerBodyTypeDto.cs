using FastCarServer.Application.Common.DTO.Abstract;

namespace FastCarServer.Application.Common.DTO.Passenger
{
    public class PassengerBodyTypeDto : MainDto
    {
        public string Name { get; set; }

        public Guid GenerationId { get; set; }
        public PassengerGenerationDto Generation { get; set; }
    }
}
