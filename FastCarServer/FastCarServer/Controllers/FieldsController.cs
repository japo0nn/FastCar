using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FastCarServer.Data.CarAbstract;
using FastCarServer.Context;

namespace FastCarServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FieldsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FieldsController(AppDbContext context)
        {
            _context = context;
        }

        
    }
}
