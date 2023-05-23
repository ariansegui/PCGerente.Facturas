namespace SQLAccess.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; } = string.Empty;
        public DateTime InvoiceDate { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public List<InvoiceItem> Items { get; set; } = new();
        public decimal TOTAL { get { return Items.Sum(item => item.Amount); } }
        public bool TaxRate { get; set; }
        public decimal TOTAL_TAX
        {
            get
            {
                if (TaxRate)
                    return Items.Sum(item => item.Amount) * 1.12m;
                return Items.Sum(item => item.Amount);
            }
        }
    }
}
