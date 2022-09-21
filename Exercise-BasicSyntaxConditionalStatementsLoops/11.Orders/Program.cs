namespace _11.Orders
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double pricePerProduct = 0.0;
            double totalPrice = 0.0;

            for (int i = 1; i <= n; i++)
            {
                double price = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int count = int.Parse(Console.ReadLine());

                pricePerProduct = (days * count) * price;
                Console.WriteLine($"The price for the coffee is: ${pricePerProduct:f2}");
                totalPrice += pricePerProduct;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
