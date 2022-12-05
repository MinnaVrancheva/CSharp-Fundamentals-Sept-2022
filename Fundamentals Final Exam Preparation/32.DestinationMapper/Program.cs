namespace _32.DestinationMapper
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|\/)(?<locationname>[A-Z][A-Za-z]{2,})(\1)";
            string input = Console.ReadLine();
            var validLocations = Regex.Matches(input, pattern);
            int travelPoints = 0;

            var matchedLocations = validLocations
                .Cast<Match>()
                .Select(x => x.Groups["locationname"].Value.Trim())
                .ToArray();

            foreach (Match match in validLocations)
            {
                travelPoints += match.Groups["locationname"].Length;
            }

            Console.Write($"Destinations: ");
            Console.WriteLine(String.Join(", ", matchedLocations));
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
