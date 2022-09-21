namespace _03.Vacation
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double pricePerPerson = 0.0;

            switch (typeOfGroup)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 8.45;
                            break;
                        case "Saturday":
                            pricePerPerson = 9.80;
                            break;
                        case "Sunday":
                            pricePerPerson = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 10.90;
                            break;
                        case "Saturday":
                            pricePerPerson = 15.60;
                            break;
                        case "Sunday":
                            pricePerPerson = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            pricePerPerson = 15;
                            break;
                        case "Saturday":
                            pricePerPerson = 20;
                            break;
                        case "Sunday":
                            pricePerPerson = 22.50;
                            break;
                    }
                    break;
            }

            double totalPrice = pricePerPerson * numberOfPeople;
            if (numberOfPeople >= 30 && typeOfGroup == "Students")
            {
                totalPrice *= 0.85;
            }
            if (numberOfPeople >= 100 && typeOfGroup == "Business")
            {
                totalPrice = totalPrice - 10 * pricePerPerson;
            }
            if (numberOfPeople >= 10 && numberOfPeople <= 20 && typeOfGroup == "Regular")
            {
                totalPrice *= 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
