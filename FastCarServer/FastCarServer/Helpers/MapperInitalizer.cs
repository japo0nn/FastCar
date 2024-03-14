using AutoMapper;
using FastCarServer.Data;
using FastCarServer.Data.CarAbstract;
using FastCarServer.Data.Passenger;
using FastCarServer.Data.User;
using FastCarServer.Dto;
using FastCarServer.Dto.CarAbstract;
using FastCarServer.Dto.Passenger;
using FastCarServer.Dto.User;

namespace FastCarServer.Helpers
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
                        dest => dest.Email,
                        opt => opt.MapFrom(src => src.IdentityUser.Email));


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
