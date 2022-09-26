namespace _10.LowerorUpper
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            bool isUpperCase = char.IsUpper(input);

            if (isUpperCase == true)
            {
                Console.WriteLine($"upper-case");
            }
            else
            {
                Console.WriteLine($"lower-case");
            }
        }
    }
}
