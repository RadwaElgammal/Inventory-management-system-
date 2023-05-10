using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Transfer
    {
        public int Id { get; set; }
        public int FromStoreId { get; set; }
        public Store FromStore { get; set; }
        public int ToStoreId { get; set; }
        public Store ToStore { get; set; }
        public DateTime TransferDate { get; set; }
        public ICollection<TransferItem> Items { get; set; }
    }
}
