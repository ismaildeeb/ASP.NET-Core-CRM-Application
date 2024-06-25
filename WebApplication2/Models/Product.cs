using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Product
    {

        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public required decimal Price { get; set; }

        [Range(0.001,1000000000000)]
        public decimal? Amount { get; set; } = 0;

    }
}
