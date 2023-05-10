using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class ImportPermit
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public Store Store { get; set; }
        public string PermitNumber { get; set; }

        [Column(TypeName = "Date")]
        public DateTime PermitDate { get; set; }
        public int SupplierId { get; set; }
        public Suppliers Supplier { get; set; }

        [Column (TypeName ="Date")]
        public DateTime ProductionDate { get; set; }

        [Column(TypeName = "Date")]
        public DateTime ExpirationDate { get; set; }
        public ICollection<ImportPermitItem> Items { get; set; }
    }
}
