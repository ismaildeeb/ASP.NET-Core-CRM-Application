using System;

namespace WebApplication2.Models
{
    public class Product
    {

        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal? Amount { get; set; }
        public Customer? Customer { get; set; }

    }
}
