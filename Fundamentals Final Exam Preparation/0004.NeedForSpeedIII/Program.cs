namespace _0004.NeedForSpeedIII
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> carMileageFuel = new Dictionary<string, List<int>>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string input = Console.ReadLine();
                string carName = input.Split('|', StringSplitOptions.RemoveEmptyEntries)[0];
                int mileage = int.Parse(input.Split('|', StringSplitOptions.RemoveEmptyEntries)[1]);
                int fuel = int.Parse(input.Split('|', StringSplitOptions.RemoveEmptyEntries)[2]);

                carMileageFuel[carName] = new List<int> { mileage, fuel };
            }

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string actionType = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries)[0];

                if (actionType == "Drive")
                {
                    string car = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries)[1];
                    int distance = int.Parse(command.Split(" : ", StringSplitOptions.RemoveEmptyEntries)[2]);
                    int fuel = int.Parse(command.Split (" : ", StringSplitOptions.RemoveEmptyEntries)[3]);

                    if (carMileageFuel[car][1] >= fuel)
                    {
                        carMileageFuel[car][1] -= fuel;
                        carMileageFuel[car][0] += distance;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (carMileageFuel[car][0] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            carMileageFuel.Remove(car);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Not enough fuel to make that ride");
                    }
                }
                else if (actionType == "Refuel")
                {
                    string car = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries)[1];
                    int fuel = int.Parse(command.Split(" : ", StringSplitOptions.RemoveEmptyEntries)[2]);
                    int amountNeeded = 75 - carMileageFuel[car][1];
                    carMileageFuel[car][1] += fuel;

                    if (carMileageFuel[car][1] >= 75)
                    {
                        carMileageFuel[car][1] = 75;
                        Console.WriteLine($"{car} refueled with {amountNeeded} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                }
                else if (actionType == "Revert")
                {
                    string car = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries)[1];
                    int kilometers = int.Parse(command.Split(" : ", StringSplitOptions.RemoveEmptyEntries)[2]);
                    carMileageFuel[car][0] -= kilometers;

                    if (carMileageFuel[car][0] >= 10000)
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                    else
                    {
                        carMileageFuel[car][0] = 10000;
                    }
                }
            }

            foreach (var (key, value) in carMileageFuel)
            {
                Console.WriteLine($"{key} -> Mileage: {value[0]} kms, Fuel in the tank: {value[1]} lt.");
            }
        }
    }
}
