using System;

namespace Assignment_6_Coffee_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink[] Drinks = new Drink[10];

            Drinks[0] = new Drink("Coffee");
            Drinks[1] = new Drink("Tea");
            Drinks[2] = new Drink("Juice");
            Drinks[3] = new Drink("Coffee");

            int Stock = 0;
            int Total = 0;

            for (int i = 0; i < Drinks.Length; i += 1)
            {
                if (Drinks[i] != null)
                {
                    Console.WriteLine(Drinks[i].GetName() + " " + Drinks[i].GetPrice());
                    Total += Drinks[i].GetPrice();
                }
                else
                {
                    //Console.WriteLine(i + " Is Null");
                    Stock += 1;
                }
            }
            Console.WriteLine("Stock Remainding: " + Stock);
            Console.WriteLine(Total + " Baht");


            int CountOfCoffee = 0;
            int CountOfTea = 0;
            int CountOfJuice = 0;

            for (int i = 0; i < Drinks.Length; i += 1)
            {
                if (Drinks[i] != null)
                {
                    if (Drinks[i].GetName() == "Coffee")
                    {
                        CountOfCoffee += 1;
                    }
                    else if (Drinks[i].GetName() == "Tea")
                    {
                        CountOfTea += 1;
                    }
                    else if (Drinks[i].GetName() == "Juice")
                    {
                        CountOfJuice += 1;
                    }
                }
            }
            Console.WriteLine("Coffee: " + CountOfCoffee);
            Console.WriteLine("Tea: " + CountOfTea);
            Console.WriteLine("Juice: " + CountOfJuice);
        }
    }
}
