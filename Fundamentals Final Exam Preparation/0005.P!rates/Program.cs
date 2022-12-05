namespace _0005.P_rates
{
    using System;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cityPopulationGold = new Dictionary<string, List<int>>();
            string input = Console.ReadLine();

            while (input != "Sail")
            {
                string cityName = input.Split("||")[0];
                int population = int.Parse(input.Split("||")[1]);
                int gold = int.Parse(input.Split("||")[2]);

                if (!cityPopulationGold.ContainsKey(cityName))
                {
                    cityPopulationGold[cityName] = new List<int> { population, gold };
                }
                else
                {
                    cityPopulationGold[cityName][0] += population;
                    cityPopulationGold[cityName][1] += gold;
                }
                input = Console.ReadLine();
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string actionType = command.Split("=>", StringSplitOptions.RemoveEmptyEntries)[0];

                if (actionType == "Plunder")
                {
                    string town = command.Split("=>", StringSplitOptions.RemoveEmptyEntries)[1];
                    int people = int.Parse(command.Split("=>", StringSplitOptions.RemoveEmptyEntries)[2]);
                    int gold = int.Parse(command.Split("=>", StringSplitOptions.RemoveEmptyEntries)[3]);

                    cityPopulationGold[town][0] -= people;
                    cityPopulationGold[town][1] -= gold;

                    if (cityPopulationGold[town][0] <= 0 || cityPopulationGold[town][1] <= 0)
                    {
                        cityPopulationGold.Remove(town);
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                    else
                    {
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    }
                }
                else if (actionType == "Prosper")
                {
                    string town = command.Split("=>", StringSplitOptions.RemoveEmptyEntries)[1];
                    int gold = int.Parse(command.Split("=>", StringSplitOptions.RemoveEmptyEntries)[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cityPopulationGold[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cityPopulationGold[town][1]} gold.");
                    }
                }
            }

            if (cityPopulationGold.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cityPopulationGold.Count} wealthy settlements to go to:");

                foreach (var (key, value) in cityPopulationGold)
                {
                    Console.WriteLine($"{key} -> Population: {value[0]} citizens, Gold: {value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
