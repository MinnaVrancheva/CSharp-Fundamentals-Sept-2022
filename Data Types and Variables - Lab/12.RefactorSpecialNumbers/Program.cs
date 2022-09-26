namespace _12.RefactorSpecialNumbers
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int kolkko = int.Parse(Console.ReadLine());

            for (int ch = 1; ch <= kolkko; ch++)
            {
                int obshto = 0;
                int takova = ch;

                while (takova > 0)
                {
                    obshto += takova % 10;
                    takova = takova / 10;
                }

                bool isSpecialNumber = (obshto == 5) || (obshto == 7) || (obshto == 11);
                Console.WriteLine("{0} -> {1}", ch, isSpecialNumber);

            }

        }
    }
}
