namespace _02.ShoppingList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceriesType = Console.ReadLine()
                .Split('!')
                .ToList();
            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] commandArray = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command1 = commandArray[0];
                string command2 = commandArray[1];
                
                switch (command1)
                {
                    case "Urgent":
                    {
                        if (groceriesType.All(x => x != command2))
                        {
                            groceriesType.Insert(0, command2);
                        }
                    break;
                    }
                    case "Unnecessary":
                    {
                        if (groceriesType.Any(x => x == command2))
                        {
                            groceriesType.Remove(command2);
                        }
                    break;
                    }
                    case "Correct":
                    {
                        string command3 = commandArray[2];
                        int newItem = groceriesType.IndexOf(command2);

                        if (groceriesType.Contains(command2))
                        {
                            groceriesType.Insert(newItem, command3);
                            groceriesType.Remove(command2);
                        }
                    break;
                    }
                    case "Rearrange":
                    {
                        if (groceriesType.Contains(command2))
                        {
                            groceriesType.Remove(command2);
                            groceriesType.Add(command2);
                        }
                    break;
                    }
                }
                
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", groceriesType));
        }
    }
}
