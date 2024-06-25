namespace WebApplication2.Models
{
    public class SalesOrderDetail
    {
        public required int Id { get; set; }
        public required int SalesOrderLine { get; set; }
        public required decimal Price { get; set; }
        public required decimal QTY { get; set; }
        public required decimal TaxAmount { get; set; }

        public required decimal Total { get; set; }

    }
}
