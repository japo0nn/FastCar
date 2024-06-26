﻿using FastCarServer.Application.Common.DTO.Abstract;

namespace FastCarServer.Application.Common.DTO.Passenger
{
    public class PassengerBrandYearDto : MainDto
    {
        public int Year { get; set; }

        public Guid BodyTypeId { get; set; }
        public PassengerBodyTypeDto BodyType { get; set; }
    }
}
