using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Products
    {
        public string name;
        public double priceAtStart 
        {
            get; set;
        }
        public int amountAtStart
        { get; set; }

        public Products(string aName, double aPriceAtStart, int aAmountAtStart)
        {
            name = aName;
            priceAtStart = aPriceAtStart;
            amountAtStart = aAmountAtStart;
        }
        public void PrintProduct() 
        {
            Console.WriteLine(name +" " + priceAtStart + " EUR " + amountAtStart + " units ");

        }
    }
}
