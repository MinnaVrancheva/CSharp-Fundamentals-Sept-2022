namespace _0002.AdAstra
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\||#)(?<itemname>[A-Za-z\s]+)(\1)(?<expirationdate>(\d{2})\/(\d{2})\/(\d{2}))(\1)(?<calories>\d+)(\1)";
            string input = Console.ReadLine();
            MatchCollection validProducts = new Regex(pattern).Matches(input);

            int totalCalories = 0;

            foreach (Match match in validProducts)
            {
                int calories = int.Parse(match.Groups["calories"].Value);
                totalCalories += calories;
            }

            int caloriesPerDay = 2000;
            int days = totalCalories / caloriesPerDay;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match match in validProducts)
            {
                string itemName = match.Groups["itemname"].Value;
                string expDate = match.Groups["expirationdate"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);

                Console.WriteLine($"Item: {itemName}, Best before: {expDate}, Nutrition: {calories}");
            }
        }
    }
}
