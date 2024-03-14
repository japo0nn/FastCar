﻿using FastCarServer.Dto.Abstract;

namespace FastCarServer.Dto.Passenger
{
    public class PassengerBodyTypeDto : MainDto
    {
        public string Name { get; set; }

        public Guid GenerationId { get; set; }
        public PassengerGenerationDto Generation { get; set; }
    }
}
