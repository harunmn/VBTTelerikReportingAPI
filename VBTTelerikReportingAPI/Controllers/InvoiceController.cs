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
    public class InvoiceController : ControllerBase
    {
        private readonly DashboardContext _context;

        public InvoiceController(DashboardContext context)
        {
            _context = context;
        }


        [HttpGet("GetInvoice/{orderId}")]
        public List<Invoices> GetInvoice(int orderId)
        {
            return _context.Invoices.Where(i => i.OrderId == orderId).ToList();
        }


    }
}
