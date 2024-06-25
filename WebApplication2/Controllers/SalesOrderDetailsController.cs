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
        private readonly ApplicationDBContext _context;
        public SalesOrderDetailsController(ApplicationDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesOrderDetail>>> GetSalesOrderDetails()
        {
            return await _context.SalesOrderDetails.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<SalesOrderDetail>> GetSalesOrderDetails(int id)
        {
            var SalesOrderDetails = await _context.SalesOrderDetails.FindAsync(id);
            if (SalesOrderDetails == null)
            {
                return NotFound();
            }
            return SalesOrderDetails;
        }
        [HttpPost]
        public async Task<ActionResult<SalesOrderDetail>> PostSalesOrderDetails(SalesOrderDetail sales_order_detail)
        {
            {
                _context.SalesOrderDetails.Add(sales_order_detail);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetSalesOrderDetails", new { id = sales_order_detail.Id });
            }

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesOrderDetails(int id, SalesOrderDetail sales_order_details)
        {

            if (id != sales_order_details.Id)
            {
                return BadRequest();
            }
            _context.Entry(sales_order_details).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
                return Ok();    
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesOrderDetailsExists(id))
                {
                    return NotFound();
                }
                    return NoContent();
                
            }
        }
        private bool SalesOrderDetailsExists(int id)
        {
            return _context.SalesOrderDetails.Any(e => e.Id == id);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalesOrderDetails(int id)
        {
            var sales_order_details = await _context.SalesOrderDetails.FindAsync(id);  
            if (sales_order_details == null)
            {
                return NotFound();
            }
            _context.SalesOrderDetails.Remove(sales_order_details);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}