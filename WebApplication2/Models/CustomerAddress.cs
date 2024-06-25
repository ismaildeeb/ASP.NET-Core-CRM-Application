namespace WebApplication2.Models
{
    public class CustomerAddress
    {

        public int Id { get; set; }
        public required Customer Customer { get; set; }
        public required string Address1 { get; set; }
        public string? Address2 { get; set; }
        public required string City { get; set; }
        public string? State { get; set; }
        public required string Postal { get; set; }
        public required string Country { get; set; }
        public bool HasShippingAddressFlag { get; set; }
        public bool HasbillingAddressFlag { get; set; }
    } 
}
