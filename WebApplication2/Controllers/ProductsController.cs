using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase 
    {
private readonly ApplicationDBContext _context;

public ProductController(ApplicationDBContext context)
{
    _context = context;
}

[HttpGet]
public async Task<ActionResult<IEnumerable<Product>>> GetCustomer(){
    return await _context.Product.ToListAsync();
}

[HttpGet("{id}")]

public async Task<ActionResult<Product>> GetProduct(int id){
    var Product = await _context.Product.FindAsync(id);
    if (Product == null)
    {
        return NotFound();
    }else{
    return Ok(Product);
    }

}

    }
}