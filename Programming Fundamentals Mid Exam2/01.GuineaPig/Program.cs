namespace _01.GuineaPig
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal foodInKg = decimal.Parse(Console.ReadLine());
            decimal hayInKg = decimal.Parse(Console.ReadLine());
            decimal coverInKg = decimal.Parse(Console.ReadLine());
            decimal weight = decimal.Parse(Console.ReadLine());

            decimal foodInGrams = foodInKg * 1000m;
            decimal hayInGrams = hayInKg * 1000m;
            decimal coverInGrams = coverInKg * 1000m;
            decimal weightInGrams = weight * 1000m;

            for (int i = 1; i <= 30; i++)
            {
                foodInGrams -= 300;
                
                if (i % 2 == 0)
                {
                    hayInGrams -= 5 * foodInGrams / 100;
                }
                if (i % 3 == 0)
                {
                    coverInGrams -= weightInGrams / 3m;
                }
                if (foodInGrams <= 0 || hayInGrams <= 0 || coverInGrams <= 0)
                {
                    Console.WriteLine($"Merry must go to the pet store!");
                    return;
                }
            }
            foodInKg = foodInGrams / 1000m;
            hayInKg = hayInGrams / 1000m;
            coverInKg = coverInGrams / 1000m;
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodInKg:f2}, Hay: {hayInKg:f2}, Cover: {coverInKg:f2}.");
        }
    }
}
