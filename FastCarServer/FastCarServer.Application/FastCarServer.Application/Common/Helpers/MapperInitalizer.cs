using AutoMapper;
using FastCarServer.Core.Data;
using FastCarServer.Core.Data.CarAbstract;
using FastCarServer.Core.Data.Passenger;
using FastCarServer.Application.Common.DTO;
using FastCarServer.Application.Common.DTO.CarAbstract;
using FastCarServer.Application.Common.DTO.Passenger;

namespace FastCarServer.WebAPI.Helpers
{
    public class MapperInitalizer
    {
        private static readonly object _locker = new object();
        public static void Initialize()
        {
            lock (_locker)
            {
                Mapper.Reset();
                Mapper.Initialize(cfg =>
                {

                    cfg.CreateMap<Category, CategoryDto>();
                    cfg.CreateMap<Field, FieldDto>();
                    cfg.CreateMap<FieldOption, FieldOptionDto>();
                    cfg.CreateMap<Property, PropertyDto>();

                    cfg.CreateMap<PassengerCategory, PassengerCategoryDto>();
                    cfg.CreateMap<PassengerBrand, PassengerBrandDto>();
                    cfg.CreateMap<PassengerBrandModel, PassengerBrandModelDto>();
                    cfg.CreateMap<PassengerBodyType, PassengerBodyTypeDto>();
                    cfg.CreateMap<PassengerBrandYear, PassengerBrandYearDto>();
                    cfg.CreateMap<PassengerGeneration, PassengerGenerationDto>();

                    cfg.CreateMap<Car, CarDto>();
                    cfg.CreateMap<PassengerCar, PassengerCarDto>();
                });
            }
        }
    }
}
