using FastCarServer.WebAPI.Dto.Abstract;

namespace FastCarServer.WebAPI.Dto.Passenger
{
    public class PassengerBodyTypeDto : MainDto
    {
        public string Name { get; set; }

        public Guid GenerationId { get; set; }
        public PassengerGenerationDto Generation { get; set; }
    }
}
