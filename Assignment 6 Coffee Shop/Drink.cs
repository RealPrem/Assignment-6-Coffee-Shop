using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6_Coffee_Shop
{
    class Drink
    {
        private string Name;
        private int Price;
        private int TimesSold = 0;

        public static int ItemCount = 0;
        public static string[] Menu = new string[3];

        public Drink(string Name, int Price)
        {
            this.Name = Name;
            this.Price = Price;
            TimesSold = TimesSold + 1;
            bool New = true;
            for(int i = 0; i < Menu.Length; i += 1)
            {
                if (Name == Menu[i])
                {
                    New = false;
                }
            }
            if (New == true)
            {
                Menu[ItemCount] = Name;
                ItemCount += 1;
            }
        }
        public static void GetItems()
        {
            for (int i = 0; i < Drink.Menu.Length; i += 1)
            {
                Console.WriteLine(Menu[i]);
            }
        }
        public int AmountSold()
        {
            return TimesSold;
        }
    }
}
