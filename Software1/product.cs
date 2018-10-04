using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1
{
    public class Product
    {
        public int productID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int inStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public List<Part> AssociatedParts { get; set; }

        //Lookup associated parts
        public dynamic LookUpAssociatedParts(dynamic part)
        {
            foreach(dynamic associatedpart in AssociatedParts)
            {
                if (part.partID.ToString() == associatedpart.partID.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        //public void addAssociatedPart = false;
        //This is handeled in AddProduct and ModProduct
        //public bool removeAssociatedPart = false;
        //This is handled in ModProduct.cs. The list essentially gets overwritten by it.  
    }
}
