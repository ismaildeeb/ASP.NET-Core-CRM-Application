namespace WebApplication2.Models
{
    public class SalesOrderBillingAddress
    {
        public int Id { get; set; }
        public required SalesOrderHeader SalesOrderHeader { get; set; }
        public required string Address1 { get; set; }
        public string? Address2 { get; set; }
        public required string City { get; set; }
        public string? State { get; set; }
        public required string Postal { get; set; }
        public required string Country { get; set; }
    }
}
