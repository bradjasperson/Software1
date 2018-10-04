using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1
{
    public abstract class Part
    {
        public int partID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int inStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public virtual void Set()
        {


        }
    }

    //InHouse Parts
    class InHouse:Part
    {
        public int MachineID { get; set; }      
    }
    //Outsourced Parts
    class Outsourced : Part
    {
        public string companyName { get; set; }
    }
}
