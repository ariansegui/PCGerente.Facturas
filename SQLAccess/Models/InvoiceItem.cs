namespace SQLAccess.Models
{
    public class InvoiceItem
    {
        public int? InvoiceId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal Quantity { get; set; }
        public decimal PriceUnit { get; set; }
        public decimal Amount { get { return Quantity * PriceUnit; } }

    }
}