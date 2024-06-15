using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class SalesOrderDetails
    {
        public int Id { get; set; }
        [Required]
        public int SalesOrderLine { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal QTY { get; set; }
        [Required]
        public decimal TaxAmount { get; set; }
        [Required]
        public decimal Total { get; set; }

    }
}
