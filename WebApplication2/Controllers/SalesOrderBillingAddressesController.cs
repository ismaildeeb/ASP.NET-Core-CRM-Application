using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesOrderBillingAddressesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public SalesOrderBillingAddressesController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesOrderBillingAddress>>> GetSalesOrderBillingAddress()
        {
            return await _context.SalesOrderBillingAddress.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SalesOrderBillingAddress>> GetSalesOrderBillingAddress(int id)
        {
            var salesOrderBillingAddress = await _context.SalesOrderBillingAddress.FindAsync(id);

            if (salesOrderBillingAddress == null)
            {
                return NotFound();
            }

            return salesOrderBillingAddress;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesOrderBillingAddress(int id, SalesOrderBillingAddress salesOrderBillingAddress)
        {
            if (id != salesOrderBillingAddress.Id)
            {
                return BadRequest();
            }

            _context.Entry(salesOrderBillingAddress).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesOrderBillingAddressExists(id))
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
        public async Task<ActionResult<SalesOrderBillingAddress>> PostSalesOrderBillingAddress(SalesOrderBillingAddress salesOrderBillingAddress)
        {
            _context.SalesOrderBillingAddress.Add(salesOrderBillingAddress);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesOrderBillingAddress", new { id = salesOrderBillingAddress.Id }, salesOrderBillingAddress);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalesOrderBillingAddress(int id)
        {
            var salesOrderBillingAddress = await _context.SalesOrderBillingAddress.FindAsync(id);
            if (salesOrderBillingAddress == null)
            {
                return NotFound();
            }

            _context.SalesOrderBillingAddress.Remove(salesOrderBillingAddress);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SalesOrderBillingAddressExists(int id)
        {
            return _context.SalesOrderBillingAddress.Any(e => e.Id == id);
        }
    }
}
