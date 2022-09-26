namespace _09.CharstoString
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            char input1 = char.Parse(Console.ReadLine());
            char input2 = char.Parse(Console.ReadLine());
            char input3 = char.Parse(Console.ReadLine());
            string text = input1.ToString() + input2.ToString() + input3.ToString();

            Console.WriteLine(text);
        }
    }
}
