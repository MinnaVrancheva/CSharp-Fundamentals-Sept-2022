namespace _02.TheLift
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = Math.Abs(int.Parse(Console.ReadLine()));
            int[] liftCurrentState = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int wagonCapacity = 4;

            for (int i = 0; i < liftCurrentState.Length; i++)
            {
                int currentWagonCapacity = wagonCapacity - liftCurrentState[i];
                
                if (numberOfPeople < currentWagonCapacity)
                {
                    liftCurrentState[i] += numberOfPeople ;
                }
                else
                {
                    liftCurrentState[i] = wagonCapacity;
                }

                numberOfPeople -= currentWagonCapacity;

                if (numberOfPeople <= 0)
                {
                    break;
                }
            }

            if (numberOfPeople > 0)
            {
                Console.WriteLine($"There isn't enough space! {numberOfPeople} people in a queue!");
                Console.WriteLine(String.Join(" ", liftCurrentState));
            }
            else if (numberOfPeople < 0)
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine(String.Join(" ", liftCurrentState));
            }
            else
            {
                Console.WriteLine(String.Join(" ", liftCurrentState));
            }
        }
    }
}
