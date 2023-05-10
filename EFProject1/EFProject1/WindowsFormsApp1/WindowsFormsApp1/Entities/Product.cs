using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        [Column (TypeName ="Date")]
        public DateTime AddDate { get; set; }
        public string UnitOfMeasure { get; set; }
        public int StoreID { get; set; }

        public virtual Store store { get; set; }
    }
}
