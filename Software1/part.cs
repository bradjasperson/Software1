using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software1
{
    abstract class Part
    {
        public virtual void Set()
        {

        }
    }
    class InHouse:Part
    {
        protected int partID;
        protected string Name;
        protected double Price;
        protected int inStock;
        protected int Min;
        protected int Max;
        protected int machineID;
        //Getters and Setters
        //PartID
        public void SetPartID(int partid)
        {
            partID = partid;
        }
        public int GetPartID()
        {
            return partID;
        }
        //Name
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        //Price
        public void SetPrice(double price)
        {
            Price = price;
        }
        public double GetPrice()
        {
            return Price;
        }
        //inStock
        public void SetStock(int stock)
        {
            inStock = stock;
        }
        public int GetStock()
        {
            return inStock;
        }
        //Min
        public void SetMin(int min)
        {
            Min = min;
        }
        public int GetMin()
        {
            return Min;
        }
        //Max
        public void SetMax(int max)
        {
            Max = max;
        }
        public int GetMax()
        {
            return Max;
        }
        //Machine ID
        public void SetMachID(int machid)
        {
            machineID = machid;
        }
        public int GetMachID()
        {
            return machineID;
        }
    }
    class Outsourced : Part
    {
        protected int partID;
        protected string Name;
        protected double Price;
        protected int inStock;
        protected int Min;
        protected int Max;
        protected string companyName;
        //Getters and Setters
        //PartID
        public void SetPartID(int partid)
        {
            partID = partid;
        }
        public int GetPartID()
        {
            return partID;
        }
        //Name
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        //Price
        public void SetPrice(double price)
        {
            Price = price;
        }
        public double GetPrice()
        {
            return Price;
        }
        //inStock
        public void SetStock(int stock)
        {
            inStock = stock;
        }
        public int GetStock()
        {
            return inStock;
        }
        //Min
        public void SetMin(int min)
        {
            Min = min;
        }
        public int GetMin()
        {
            return Min;
        }
        //Max
        public void SetMax(int max)
        {
            Max = max;
        }
        public int GetMax()
        {
            return Max;
        }
        //Company Name
        public void SetCompanyName(string compname)
        {
            companyName = compname;
        }
        public string GetCompanyName()
        {
            return companyName;
        }
    }
}
