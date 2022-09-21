namespace _09.PadawanEquipment
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsNumber = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double freebelts = studentsNumber / 6;
            double lightsabers = Math.Ceiling(studentsNumber * 1.1) * lightsaberPrice;
            double robes = robePrice * studentsNumber;
            double belts = beltPrice * (studentsNumber - freebelts);

            double finalPrice = lightsabers + robes + belts;
            if (money >= finalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {finalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {finalPrice - money:f2}lv more.");
            }
        }
    }
}
