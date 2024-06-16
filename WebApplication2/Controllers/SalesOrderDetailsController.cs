using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderDetailsController : ControllerBase
    {
        private readonly ApplicationDBContext _context ;
        public SalesOrderDetailsController(ApplicationDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesOrderDetails>>> GetSalesOrderDetails()
        {
            return await _context.SalesOrderDetails.ToListAsync();
        }
        [HttpGet]
        public async Task<ActionResult<SalesOrderDetails>> GetSalesOrderDetails(int id)
        {
            var SalesOrderDetails = await _context.SalesOrderDetails.FindAsync(id);
            if (SalesOrderDetails == null) { 
            return NotFound();
            }
            else {
            return Ok(SalesOrderDetails);   
            }
        }
        [HttpPut]
        public async ActionResult<>
    }
}
