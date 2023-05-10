namespace WindowsFormsApp1.Entities
{
    public class ExchangePermitItem
    {
        public int Id { get; set; }
        public int ExchangePermitId { get; set; }
        public ExchangePermit ExchangePermit { get; set; }
        public int ItemId { get; set; }
        public Product Item { get; set; }
        public int Quantity { get; set; }
    }
}