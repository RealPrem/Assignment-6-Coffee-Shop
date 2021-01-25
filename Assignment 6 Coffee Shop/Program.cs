using System;

namespace Assignment_6_Coffee_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink Coffee = new Drink("Coffee", 50);
            Drink Tea = new Drink("Tea", 45);
            Drink.GetItems();
            Console.WriteLine(Coffee.AmountSold());
        }
    }
}
