using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string UnitOfMeasure { get; set; }
        public int StoreID { get; set; }
    }
}
