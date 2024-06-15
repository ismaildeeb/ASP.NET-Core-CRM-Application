namespace WebApplication2.Models
{
    public class SalesOrderHeader
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
        public Customer? Customer { get; set; }
        public decimal Tax { get; set; }
        public decimal Subtotal { get; set; }
        public decimal GrandTotal { get; set; }
        public required string AddressShipping { get; set; }
        public required string Addressbilling { get; set; }


    }
}
