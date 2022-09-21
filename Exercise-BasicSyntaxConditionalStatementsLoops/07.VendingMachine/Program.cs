namespace _07.VendingMachine
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double money = 0.0;
            
            while (command != "Start")
            {
                double coin = double.Parse(command);
                money += coin;

                if (coin != 0.1 && coin != 0.2 && coin != 0.5 && coin != 1 && coin != 2)
                {
                    Console.WriteLine($"Cannot accept {coin}");
                    money -= coin;
                }
                command = Console.ReadLine();
            }

            string command2 = Console.ReadLine();
            double productPrice = 0.0;

            while (command2 != "End")
            {
                switch (command2)
                {
                    case "Nuts":
                        productPrice = 2.0;
                        break;
                    case "Water":
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine($"Invalid product");
                        goto done;
                }
                if (money >= productPrice)
                {
                    string productName = command2.ToLower();
                    Console.WriteLine($"Purchased {productName}");
                    money -= productPrice;
                }
                else
                {
                    Console.WriteLine($"Sorry, not enough money");
                }
                done:
                command2 = Console.ReadLine();
            }
            Console.WriteLine($"Change: {money:f2}");
        }
    }
}
