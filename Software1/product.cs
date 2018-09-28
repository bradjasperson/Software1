using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1
{
    public class Product
    {
        public int partID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int inStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public List<Part> AssociatedParts { get; set; }
    }
}
