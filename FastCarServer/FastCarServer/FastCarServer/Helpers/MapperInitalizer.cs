using AutoMapper;
using FastCarServer.Data;
using FastCarServer.Data.CarAbstract;
using FastCarServer.Data.Passenger;
using FastCarServer.Data.User;
using FastCarServer.WebAPI.Dto;
using FastCarServer.WebAPI.Dto.CarAbstract;
using FastCarServer.WebAPI.Dto.Passenger;
using FastCarServer.WebAPI.Dto.User;

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
                    cfg.CreateMap<User, UserDto>().ForMember(
                        dest => dest.PhoneNumber,
                        opt => opt.MapFrom(src => src.IdentityUser.PhoneNumber));


                    cfg.CreateMap<Category, CategoryDto>();
                    cfg.CreateMap<Field, FieldDto>();
                    cfg.CreateMap<FieldOption, FieldOptionDto>();
                    cfg.CreateMap<Properties, PropertyDto>();

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
