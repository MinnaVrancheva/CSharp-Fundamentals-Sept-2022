namespace _06.StrongNumber
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;
            int factorialSum = 0;

            while (numberCopy > 0)
            {
                int lastDigit = numberCopy % 10;
                numberCopy = numberCopy / 10;

                int facrorial = 1;
                for (int i = 1; i <= lastDigit; i++)
                {
                    facrorial *= i;
                }
                factorialSum += facrorial;
            }
            if (factorialSum == number)
            {
                Console.WriteLine($"yes");
            }
            else
            {
                Console.WriteLine($"no");
            }
        }
    }
}
