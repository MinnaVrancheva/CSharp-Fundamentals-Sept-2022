namespace _01.CookingMasterclass
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double students = int.Parse(Console.ReadLine());
            double flourPackagePrice = double.Parse(Console.ReadLine());
            double singleEggPrice = double.Parse(Console.ReadLine());
            double singleApronPrice = double.Parse(Console.ReadLine());

            double freeFlourPackages = 0;
            for (int i = 1; i <= students; i++)
            {
                if (i % 5 == 0)
                {
                    freeFlourPackages++;
                }
            }
            double finalFlourPrice = flourPackagePrice * students - freeFlourPackages * flourPackagePrice;
            double finalEggPrice = singleEggPrice * 10 * students;

            double percentage = Math.Ceiling(20 * students / 100);
            double finalApronPrice = singleApronPrice * (students + percentage);

            double finalPrice = finalFlourPrice + finalEggPrice + finalApronPrice;

            if (finalPrice <= budget)
            {
                Console.WriteLine($"Items purchased for {finalPrice:f2}$.");
            }
            else
            {
                Console.WriteLine($"{finalPrice - budget:f2}$ more needed.");
            }

        }
    }
}
