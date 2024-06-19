using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FastCarServer.Data;
using FastCarServer.Infrastructure.Data;
using AutoMapper;
using FastCarServer.Core.Data.Passenger;
using FastCarServer.WebAPI.Dto.Passenger;

namespace FastCarServer.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet("getCategories")]
        public async Task<List<PassengerCategoryDto>> AddCategory()
        {
            var categories = await _context.PassengerCategories.ToListAsync();

            return Mapper.Map<List<PassengerCategory>, List<PassengerCategoryDto>>(categories);
        }
    }
}
