namespace _03.GamingStore
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string gameTitle = Console.ReadLine();
            
            double totalExpenses = 0;
            double moneyLeft = balance;

            while (gameTitle != "Game Time")
            {
                double gamePrice = 0;
                switch (gameTitle)
                {
                    case "OutFall 4":
                        gamePrice = 39.99;
                        break;
                    case "CS: OG":
                        gamePrice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gamePrice = 19.99;
                        break;
                    case "Honored 2":
                        gamePrice = 59.99;
                        break;
                    case "RoverWatch":
                        gamePrice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gamePrice = 39.99;
                        break;
                    default:
                        Console.WriteLine($"Not Found");
                        goto Read;
                }

                totalExpenses += gamePrice;

                if (gamePrice > moneyLeft)
                {
                    Console.WriteLine($"Too Expensive");
                    totalExpenses -= gamePrice;
                    goto Read;
                }

                if (balance >= totalExpenses)
                {
                    Console.WriteLine($"Bought {gameTitle}");
                    moneyLeft -= gamePrice;
                }
                if (moneyLeft == 0)
                {
                    Console.WriteLine($"Out of money!");
                    return;
                }
            Read:
                gameTitle = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${totalExpenses:f2}. Remaining: ${balance - totalExpenses:f2}");
        }
    }
}
