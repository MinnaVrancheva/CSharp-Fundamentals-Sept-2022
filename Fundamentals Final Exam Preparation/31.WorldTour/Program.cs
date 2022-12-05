namespace _31.WorldTour
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string allStops = Console.ReadLine();
            string command;

            while ((command = Console.ReadLine()) != "Travel")
            {
                string actionType = command.Split(':')[0];

                if (actionType == "Add Stop")
                {
                    int index = int.Parse(command.Split(':')[1]);
                    string newStop = command.Split(':')[2];
                    
                    if (index >= 0 && index < allStops.Length)
                    {
                        allStops = allStops.Insert(index, newStop);
                    }
                    Console.WriteLine(allStops);
                }
                else if (actionType == "Remove Stop")
                {
                    int startIndex = int.Parse(command.Split(':')[1]);
                    int endIndex = int.Parse(command.Split(':')[2]);

                    if (startIndex >= 0 && startIndex < allStops.Length && endIndex >= 0 && endIndex < allStops.Length)
                    {
                        allStops = allStops.Remove(startIndex, endIndex - startIndex + 1);
                    }
                    Console.WriteLine(allStops);
                }
                else if (actionType == "Switch")
                {
                    string oldString = command.Split(':')[1];
                    string newString = command.Split(':')[2];

                    if (allStops.Contains(oldString))
                    {
                        allStops = allStops.Replace(oldString, newString);
                    }
                    Console.WriteLine(allStops);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {allStops}");
        }
    }
}
