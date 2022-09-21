namespace _04.ReverseString
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
        }
    }
}
