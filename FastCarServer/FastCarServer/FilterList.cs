/*using AutoMapper;
using FastCarServer.Context;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace FastCarServer
{
    public class FilterList
    {
        private readonly AppDbContext _dbContext;
        public FilterList(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<PageViewDto<CarDto>> GetCars(SearchDataDto? searchDataModel, int page = 1)
        {
            int pageSize = 10;
            if (page <= 0)
            {
                page = 1;
            }
            IQueryable<Car> cars = _dbContext.Cars.Include(x => x.CarProperties).ThenInclude(p => p.CarField);
            IQueryable<CarProperty> carProperties = _dbContext.CarProperties;
            IQueryable<CarBrandYear> carBrandYears = _dbContext.CarBrandYears;
            IQueryable<CarBodyType> carBodyTypes = _dbContext.CarBodyTypes;

            ApplyFilter(searchDataModel, ref cars, ref carProperties, ref carBrandYears, ref carBodyTypes);
            var count = await cars.CountAsync();
            cars = cars
                .Include(cat => cat.Category)
                .Include(br => br.CarBrand)
                .Include(mod => mod.CarBrandModel)
                .Include(year => year.CarBrandYear)
                .Include(bt => bt.CarBodyType)
                .Include(g => g.CarGeneration)
                .Include(o => o.Owner).ThenInclude(x => x.IdentityUser)
                .Include(i => i.Images.OrderByDescending(x => x.FileUrl))
                .OrderByDescending(d => d.DateCreated)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);


            PageViewDto<CarDto> viewModel = new PageViewDto<CarDto>(count, page, pageSize)
            {
                Items = await cars.Select(x => Mapper.Map<Car, CarDto>(x)).ToListAsync()
            };
            return viewModel;
        }

        public async Task<List<CarLocationDto>> GetLocations(SearchDataDto? searchDataModel)
        {
            IQueryable<Car> cars = _dbContext.Cars.Include(x => x.CarProperties).ThenInclude(p => p.CarField);
            IQueryable<CarProperty> carProperties = _dbContext.CarProperties;
            IQueryable<CarBrandYear> carBrandYears = _dbContext.CarBrandYears;
            IQueryable<CarBodyType> carBodyTypes = _dbContext.CarBodyTypes;

            ApplyFilter(searchDataModel, ref cars, ref carProperties, ref carBrandYears, ref carBodyTypes);

            IQueryable<CarLocation> queryLocations = _dbContext.CarLocations;
            queryLocations = from car in cars
                             join loc in queryLocations on car.Id equals loc.CarId
                             select loc;

            var locations = await queryLocations.ToListAsync();
            return Mapper.Map<List<CarLocation>, List<CarLocationDto>>(locations);
        }

        private void ApplyFilter(SearchDataDto? searchDataModel, ref IQueryable<Car> cars, ref IQueryable<CarProperty> carProperties,
                        ref IQueryable<CarBrandYear> carBrandYears, ref IQueryable<CarBodyType> carBodyTypes)
        {
            if (searchDataModel.CarBrandId != null)
            {
                foreach (var brandId in searchDataModel.CarBrandId)
                {
                    if (searchDataModel.CarBrandModelId != null)
                    {
                        foreach (var modelId in searchDataModel.CarBrandModelId)
                        {
                            cars = (from car in cars.Where(x => x.CarBrandModelId == modelId) select car);

                        }
                    }
                    else
                    {
                        cars = (from car in cars.Where(x => x.CarBrandId == brandId) select car);
                    }
                }
            }
            if (searchDataModel.FromPrice != 0 || searchDataModel.ToPrice != int.MaxValue)
            {
                cars = (from car in cars.Where(x => x.Price >= searchDataModel.FromPrice && x.Price <= searchDataModel.ToPrice) select car);
            }
            if (searchDataModel.FromCapacity != 0 || searchDataModel.ToCapacity != 9.9F)
            {
                cars = (from car in cars.Where(x => x.Capacity >= searchDataModel.FromCapacity && x.Capacity <= searchDataModel.ToCapacity) select car);
            }
            if (searchDataModel.FromYear != 0 || searchDataModel.ToYear != DateTime.UtcNow.Year)
            {
                cars = (from year in carBrandYears.Where(x => x.Year >= searchDataModel.FromYear && x.Year <= searchDataModel.ToYear)
                        join c in cars on year.Id equals c.CarBrandYearId
                        select c);
            }
            if (searchDataModel.BodyType != string.Empty)
            {
                cars = (from bodytype in carBodyTypes.Where(x => x.Name == searchDataModel.BodyType)
                        join c in cars on bodytype.Id equals c.CarBodyTypeId
                        select c);
            }
            if (!string.IsNullOrEmpty(searchDataModel.Status))
                cars = (from car in cars.Where(x => x.Status == searchDataModel.Status) select car);
            if (searchDataModel.CarProperties != null)
            {
                foreach (var property in searchDataModel.CarProperties)
                {
                    string[] propsValues = property.CarFieldValue.Split(" ");
                    for (int i = 0; i < propsValues.Length; i++)
                    {
                        cars = (from prop in carProperties
                            .Where(x => x.CarFieldId == property.CarFieldId && propsValues.Contains(x.CarFieldValue))
                                join c in cars on prop.CarId equals c.Id
                                select c
                            );
                    }
                }
            }
        }
    }
}
*/