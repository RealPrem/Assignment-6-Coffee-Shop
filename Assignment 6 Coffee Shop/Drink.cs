using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6_Coffee_Shop
{
    class Drink
    {
        private string Name;
        private int Price;
        public Drink(string Name)
        {
            this.Name = Name;
            if (Name == "Coffee")
            {
                Price = 50;
            }
            else if (Name == "Tea")
            {
                Price = 45;
            }
            else if (Name == "Juice")
            {
                Price = 30;
            }
        }
        public string GetName()
        {
            return Name;
        }
        public int GetPrice()
        {
            return Price;
        }
    }
}
