namespace _03.MovingTarget
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targetsSequence = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string input = command.Split(' ')[0];
                int index = int.Parse(command.Split(' ')[1]);
                int input2 = int.Parse(command.Split(' ')[2]);
                
                    switch (input)
                    {
                        case "Shoot":
                        if (index >= 0 && index < targetsSequence.Count)
                        {
                            targetsSequence[index] -= input2;

                            if (targetsSequence[index] <= 0)
                            {
                                targetsSequence.RemoveAt(index);
                            }
                        } 
                        break;
                        case "Add":
                        if (index >= 0 && index < targetsSequence.Count)
                        {
                            targetsSequence.Insert(index, input2);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid placement!");
                        }
                        break;
                        case "Strike":
                        if (index - input2 >= 0 && index < targetsSequence.Count)
                        {
                            targetsSequence.RemoveRange(index - input2, input2 * 2 + 1);
                        }
                        else
                        {
                            Console.WriteLine($"Strike missed!");
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join("|", targetsSequence));
        }
    }
}
