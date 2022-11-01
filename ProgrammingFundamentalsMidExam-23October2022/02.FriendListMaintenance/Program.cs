namespace _02.FriendListMaintenance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                .Split(", ")
                .ToList();
            string command = Console.ReadLine();
            int numberOfBlacklistedNames = 0;
            int lostNames = 0;

            while (command != "Report")
            {
                string command1 = command.Split()[0];
                string command2 = command.Split()[1];
                if (command1 == "Blacklist")
                {
                    if (names.Contains(command2))
                    {
                        Console.WriteLine($"{command2} was blacklisted.");
                        names.Insert(names.IndexOf(command2), "Blacklisted");
                        names.Remove(command2);
                        numberOfBlacklistedNames++;
                    }
                    else
                    {
                        Console.WriteLine($"{command2} was not found.");
                    }
                }
                if (command1 == "Error")
                {
                    int index = int.Parse(command2);
                    if (index >= 0 && index < names.Count && names[index] != "Blacklisted" && names[index] != "Lost")
                    {
                        Console.WriteLine($"{names[index]} was lost due to an error.");
                        names.Insert(index, "Lost");
                        names.RemoveAt(index + 1);
                        lostNames++;
                    }
                }
                if (command1 == "Change")
                {
                    int index = int.Parse(command2);
                    string command3 = command.Split()[2];
                    if (index >= 0 && index < names.Count)
                    {
                        Console.WriteLine($"{names[index]} changed his username to {command3}.");
                        names.Insert(index, command3);
                        names.RemoveAt(index + 1);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Blacklisted names: {numberOfBlacklistedNames}");
            Console.WriteLine($"Lost names: {lostNames}");
            Console.WriteLine(String.Join(" ", names));
        }
    }
}
