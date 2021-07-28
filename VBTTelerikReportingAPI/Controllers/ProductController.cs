using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VBTTelerikReportingAPI.Entities;
using VBTTelerikReportingAPI.Entities.DbContexts;

namespace VBTTelerikReportingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DashboardContext _context;

        public ProductController(DashboardContext context)
        {
            _context = context;
        }

        [HttpGet("ProductList")]
        public List<AlphabeticalListOfProducts> ProductList()
        {
            return _context.AlphabeticalListOfProducts.ToList();
        }
    }
}
