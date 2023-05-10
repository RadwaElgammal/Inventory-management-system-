using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class ExchangePermit
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public string ExchangeNumber { get; set; }

        [Column(TypeName = "Date")]
        public DateTime ExchangeDate { get; set; }
        public int SupplierId { get; set; }
        public Suppliers Supplier { get; set; }
        public ICollection<ExchangePermitItem> Items { get; set; }

    }
}
