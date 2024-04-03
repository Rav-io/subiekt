using Microsoft.AspNetCore.Mvc;
using SubiektGT.Models;

namespace SubiektGT.Controllers
{
    [ApiController]
    [Route("api/clients")]
    public class ClientController : Controller
    {
        private readonly AppDbContext _context;

        public ClientController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetClients()
        {
            var clients = _context.Clients.Select(i => new
            {
                Id = i.Id,
                Name = i.Name,
                Email = i.Email,
            }).ToList();


            return Ok(clients);
        }
    }
}