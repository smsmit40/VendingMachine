using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class VendingMachine
    {
        private string name;
        private double price;
        private int storage;
        
        public VendingMachine(string name, double age, int title)
        {
            this.name = name;
            this.price = age;
            this.storage = title;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Storage
        {
            get { return storage; }
            set { storage = value; }
        }
       
    }
}
