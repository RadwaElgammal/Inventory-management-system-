using System;

namespace WindowsFormsApp1.Entities
{
    public class TransferItem
    {
        public int Id { get; set; }
        public int TransferId { get; set; }
        public Transfer Transfer { get; set; }
        public int ItemId { get; set; }
        public Product Item { get; set; }
        public int Quantity { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}