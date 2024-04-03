using Microsoft.AspNetCore.Mvc;
using SubiektGT.Models;

namespace SubiektGT.Controllers
{
    [ApiController]
    [Route("api/invoices")]
    public class InvoiceController : Controller
    {
        private readonly AppDbContext _context;

        public InvoiceController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetInvoices()
        {
            var invoices = _context.Invoices.Select(i => new
            {
                Id = i.Id,
                Numer = i.Numer,
                Kontrahent = i.Kontrahent,
                Wartosc = i.Wartosc,
            }).ToList();


            return Ok(invoices);
        }
    }
}