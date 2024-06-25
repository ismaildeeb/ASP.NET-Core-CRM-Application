using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderShippingAddressesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public SalesOrderShippingAddressesController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesOrderShippingAddress>>> GetSalesOrderShippingAddress()
        {
            return await _context.SalesOrderShippingAddress.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SalesOrderShippingAddress>> GetSalesOrderShippingAddress(int id)
        {
            var salesOrderShippingAddress = await _context.SalesOrderShippingAddress.FindAsync(id);

            if (salesOrderShippingAddress == null)
            {
                return NotFound();
            }

            return salesOrderShippingAddress;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesOrderShippingAddress(int id, SalesOrderShippingAddress salesOrderShippingAddress)
        {
            if (id != salesOrderShippingAddress.Id)
            {
                return BadRequest();
            }

            _context.Entry(salesOrderShippingAddress).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesOrderShippingAddressExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<SalesOrderShippingAddress>> PostSalesOrderShippingAddress(SalesOrderShippingAddress salesOrderShippingAddress)
        {
            _context.SalesOrderShippingAddress.Add(salesOrderShippingAddress);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesOrderShippingAddress", new { id = salesOrderShippingAddress.Id }, salesOrderShippingAddress);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalesOrderShippingAddress(int id)
        {
            var salesOrderShippingAddress = await _context.SalesOrderShippingAddress.FindAsync(id);
            if (salesOrderShippingAddress == null)
            {
                return NotFound();
            }

            _context.SalesOrderShippingAddress.Remove(salesOrderShippingAddress);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SalesOrderShippingAddressExists(int id)
        {
            return _context.SalesOrderShippingAddress.Any(e => e.Id == id);
        }
    }
}
