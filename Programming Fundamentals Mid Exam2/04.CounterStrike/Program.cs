namespace _04.CounterStrike
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int battlesWon = 0;

            while (command != "End of battle")
            {
                int distance = int.Parse(command);
                if (energy >= distance)
                {
                    energy -= distance;
                    battlesWon++;
                    if (battlesWon % 3 == 0)
                    {
                        energy += battlesWon;
                    }
                }
                else if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesWon} won battles and {energy} energy");
                    return;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {battlesWon}. Energy left: {energy}");
        }
    }
}
