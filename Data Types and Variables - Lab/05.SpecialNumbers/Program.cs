namespace _05.SpecialNumbers
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= n; i++)
            {
                int sum = 0;
                int currentN = i;
                
                while (currentN > 0)
                {
                    sum += currentN % 10;
                    currentN /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
