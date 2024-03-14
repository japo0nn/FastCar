using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FastCarServer.Data;
using FastCarServer.Context;
using FastCarServer.Dto.Passenger;
using AutoMapper;
using FastCarServer.Data.Passenger;

namespace FastCarServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriesController(AppDbContext context)
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
