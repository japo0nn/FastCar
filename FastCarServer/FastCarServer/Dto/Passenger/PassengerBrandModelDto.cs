﻿using FastCarServer.Dto.Abstract;

namespace FastCarServer.Dto.Passenger
{
    public class PassengerBrandModelDto : MainDto
    {
        public string Name { get; set; }

        public Guid BrandYearId { get; set; }
        public PassengerBrandYearDto BrandYear { get; set; }
    }
}
