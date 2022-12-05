namespace _01.ComputerStore
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double priceBeforeTaxes = 0;
            double totalPrice = 0;

            while (input != "special" && input != "regular")
            {
                double partPrice = double.Parse(input);

                priceBeforeTaxes += partPrice;
                
                if (partPrice < 0)
                {
                    Console.WriteLine($"Invalid price!");
                    priceBeforeTaxes -= partPrice;
                }
                input = Console.ReadLine();
            }

            double taxes = priceBeforeTaxes / 100 * 20;
            totalPrice = priceBeforeTaxes + taxes;

            if (input == "special")
            {
                totalPrice *= 0.9; 
            }
            if (totalPrice == 0)
            {
                Console.WriteLine($"Invalid order!");
            }
            else
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceBeforeTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");
            }
        }
    }
}
