namespace _03.MemoryGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(' ')
                .ToList();
            string input = Console.ReadLine();
            int length = elements.Count;
            int movesCount = 0;

            while (input != "end")
            {
                string[] command = input.Split(' ');
                int index1 = int.Parse(command[0]);
                int index2 = int.Parse(command[1]);

                    movesCount++;
                    if (index1 == index2 || index1 < 0 || index1 > elements.Count - 1 || index2 < 0 || index2 > elements.Count - 1)
                    {
                        elements.Insert(elements.Count / 2, $"-{movesCount}a");
                        elements.Insert(elements.Count / 2, $"-{movesCount}a");
                        Console.WriteLine($"Invalid input! Adding additional elements to the board");
                        length += 2;
                    }

                    else if (elements[index1] == elements[index2])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {elements[index1]}!");
                        if (index1 > index2)
                        {
                            elements.RemoveAt(index1);
                            elements.RemoveAt(index2);
                        }
                        else
                        {
                            elements.RemoveAt(index2);
                            elements.RemoveAt(index1);
                        }
                        length -= 2;
                    }
                    else if (elements[index1] != elements[index2])
                    {
                        Console.WriteLine($"Try again!");
                    }
                    if (length == 0)
                    {
                        Console.WriteLine($"You have won in {movesCount} turns!");
                        return;
                    }
                input = Console.ReadLine();
            }

            if (length > 0)
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(String.Join(" ", elements));
            }
        }
    }
}
