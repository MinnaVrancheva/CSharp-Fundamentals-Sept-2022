namespace _11.RefactorVolumeofPyramid
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            Console.Write("Length: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double heigth = double.Parse(Console.ReadLine());
            Console.Write("Height: ");

            double volume = (length * width * heigth) / 3;
            Console.Write($"Pyramid Volume: {volume:f2}");


            //double dul, sh, V = 0;
            //Console.WriteLine("Length: ");
            //dul = double.Parse(Console.ReadLine());
            //Console.WriteLine("Width: ");
            //sh = double.Parse(Console.ReadLine());
            //Console.WriteLine("Heigth: ");
            //V = double.Parse(Console.ReadLine());
            //V = (dul + sh + V) / 3;
            //Console.WriteLine($"Pyramid Volume: {V:f2}");

        }
    }
}
