namespace _05.Messages
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string length = string.Empty;
            
            for (int i = 0; i < input; i++)
            {
                string digits = Console.ReadLine();
                int digitsLength = digits.Length;
                int digit = digits[0] - '0';
                int offset = (digit - 2) * 3;

                if (digit == 0)
                {
                    length += (char)(digit + 32);
                    continue;
                }
                if (digit == 8 || digit == 9)
                {
                    offset++;
                }

                int index = offset + digitsLength - 1;
                length += (char)(index + 97);
            }
            Console.WriteLine(length);
        }
    }
}
