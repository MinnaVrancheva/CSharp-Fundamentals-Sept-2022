namespace _33.PlantDiscovery
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlants = int.Parse(Console.ReadLine());
            Dictionary<string, int> plantNamesAndRarity = new Dictionary<string, int>();
            Dictionary<string, List<double>> plantNamesAndRatings = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfPlants; i++)
            {
                string input = Console.ReadLine();
                string plantName = input.Split("<->")[0];
                int rarity = int.Parse(input.Split("<->")[1]);

                if (!plantNamesAndRarity.ContainsKey(plantName))
                {
                    plantNamesAndRarity.Add(plantName, rarity);
                    plantNamesAndRatings[plantName] = new List<double>();
                }
                else
                {
                    plantNamesAndRarity[plantName] = rarity;
                }
            }
            string command;

            while ((command = Console.ReadLine()) != "Exhibition")
            {
                string[] action = command.Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string actionType = action[0].Trim();
                string secondAction = action[1].Trim();
                string[] secondActionArray = secondAction.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (actionType == "Rate")
                {
                    string plant = secondActionArray[0].Trim();
                    double rating = double.Parse(secondActionArray[1].Trim());

                    if (!plantNamesAndRarity.ContainsKey(plant))
                    {
                        Console.WriteLine($"error");
                    }
                    else
                    {
                        //plantNamesAndRatings[plant] = new List<int>();
                        plantNamesAndRatings[plant].Add(rating);
                    }
                }
                else if (actionType == "Update")
                {
                    string plant = secondActionArray[0].Trim();
                    int newRarity = int.Parse(secondActionArray[1].Trim());

                    if (!plantNamesAndRarity.ContainsKey(plant))
                    {
                        Console.WriteLine($"error");
                    }
                    else
                    {
                        plantNamesAndRarity[plant] = newRarity;
                    }
                }
                else if (actionType == "Reset")
                {
                    string plant = secondActionArray[0].Trim();

                    if (!plantNamesAndRarity.ContainsKey(plant))
                    {
                        Console.WriteLine($"error");
                    }
                    else
                    {
                        plantNamesAndRatings[plant].Clear();
                    }
                }
            }

            double avgRatings = 0;
            Dictionary<string, List<double>> plantAvgRatings = new Dictionary<string, List<double>>();

            foreach (var plant in plantNamesAndRatings)
            {
                string plantName = plant.Key;
                double rarity = plantNamesAndRarity[plant.Key];
                plantAvgRatings[plantName] = new List<double>();

                if (plantNamesAndRatings[plant.Key].Count > 0)
                {
                    avgRatings = plantNamesAndRatings[plant.Key].Average();
                    plantAvgRatings[plantName].Add(rarity);
                    plantAvgRatings[plantName].Add((double)avgRatings);
                }
                else
                {
                    avgRatings = 0;
                    plantAvgRatings[plantName].Add(rarity);
                    plantAvgRatings[plantName].Add((double)avgRatings);
                }
            }

            Console.WriteLine("Plants for the exhibition: ");

            foreach (var plant in plantAvgRatings)
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value[0]}; Rating: {plant.Value[1]:F2}");
            }
        }
    }
}
