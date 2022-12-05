namespace _02.TheLift
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int[] liftCurrentState = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            
            for (int i = 0; i < liftCurrentState.Length; i++)
            {
                if (liftCurrentState[i] < 4)
                {
                    while (liftCurrentState[i] < 4 && numberOfPeople > 0)
                    {
                        liftCurrentState[i]++;
                        numberOfPeople--;
                    }
                }
            }
            if (numberOfPeople == 0 && liftCurrentState.Any(x => x < 4))
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine(String.Join(" ", liftCurrentState));
            }
            else if (numberOfPeople == 0 && liftCurrentState.All(x => x == 4))
            {
                Console.WriteLine(String.Join(" ", liftCurrentState));
            }
            else
            {
                Console.WriteLine($"There isn't enough space! {numberOfPeople} people in a queue!");
                Console.WriteLine(String.Join(" ", liftCurrentState));
            }
        }
    }
}
