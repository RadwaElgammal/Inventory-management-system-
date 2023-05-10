namespace WindowsFormsApp1.Entities
{
    public class ImportPermitItem
    {
        public int Id { get; set; }
        public int ImportPermitId { get; set; }
        public ImportPermit ImportPermit { get; set; }
        public int ItemId { get; set; }
        public Product Item { get; set; }
        public int Quantity { get; set; }
    }
}