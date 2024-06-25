using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
namespace WebApplication2.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Product { get; set; }
        public DbSet<SalesOrderHeader> SalesOrderHeader { get; set; }
        public DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public DbSet<WebApplication2.Models.SalesOrderBillingAddress> SalesOrderBillingAddress { get; set; } = default!;
        public DbSet<WebApplication2.Models.SalesOrderShippingAddress> SalesOrderShippingAddress { get; set; } = default!;
    }
}
