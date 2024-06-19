using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using FastCarServer.Core.Data.Passenger;
using FastCarServer.Infrastructure.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FastCarServer.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ValuesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("addTestModels")]
        public async Task AddTestModels()
        {
            var Generation = new PassengerGeneration()
            {
                Name = "Test Generation",
            };
            await _context.PassengerGenerations.AddAsync(Generation);

            var bodyType = new PassengerBodyType()
            {
                Name = "Test Body Type",
                GenerationId = Generation.Id,
            };
            await _context.PassengerBodyTypes.AddAsync(bodyType);

            var brandYear = new PassengerBrandYear()
            {
                Year = 2001,
                BodyTypeId = bodyType.Id
            };
            await _context.PassengerBrandYears.AddAsync(brandYear);

            var brandModel = new PassengerBrandModel()
            {
                Name = "Test brand model",
                BrandYearId = brandYear.Id,
            };
            await _context.PassengerBrandModels.AddAsync(brandModel);

            var brand = new PassengerBrand()
            {
                Name = "Test Brand",
                BrandModelId = brandModel.Id,
            };
            await _context.PassengerBrands.AddAsync(brand);

            var category = new PassengerCategory()
            {
                BrandId = brand.Id
            };
            await _context.PassengerCategories.AddAsync(category);

            await _context.SaveChangesAsync();
        }
    }
}
