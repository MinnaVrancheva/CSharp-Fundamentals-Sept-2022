namespace _03.HeartDelivery
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] neighborhood = Console.ReadLine()
                .Split('@', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string jumpCommand = Console.ReadLine();
            int currentPosition = 0;
            int housesWithoutLove = neighborhood.Length;
            int houseWithLove = 0;

            while (jumpCommand != "Love!")
            {
                string command = jumpCommand.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];
                int length = int.Parse(jumpCommand.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
                currentPosition += length;

                if (currentPosition > neighborhood.Length - 1)
                {
                    currentPosition = 0;
                }

                if (neighborhood[currentPosition] > 0)
                {
                    neighborhood[currentPosition] -= 2;
                    if (neighborhood[currentPosition] == 0)
                    {
                        housesWithoutLove--;
                        houseWithLove++;
                        Console.WriteLine($"Place {currentPosition} has Valentine's day.");
                    }
                }
                else if (neighborhood[currentPosition] == 0)
                {
                    Console.WriteLine($"Place {currentPosition} already had Valentine's day.");
                }

                jumpCommand = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {currentPosition}.");
            if (housesWithoutLove > 0)
            {
                Console.WriteLine($"Cupid has failed {housesWithoutLove} places.");
            }
            else
            {
                Console.WriteLine($"Mission was successful.");
            }
        }
    }
}

