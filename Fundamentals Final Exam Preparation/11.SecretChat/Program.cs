namespace _11.SecretChat
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command;

            while ((command = Console.ReadLine()) != "Reveal")
            {
                string actionType = command.Split(":|:")[0];

                if (actionType == "InsertSpace")
                {
                    int index = int.Parse(command.Split(":|:")[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (actionType == "Reverse")
                {
                    string substring = command.Split(":|:")[1];
                    int index = message.IndexOf(substring);

                    if (message.Contains(substring))
                    {
                        message = message.Remove(index, substring.Length);
                        string reversedSubstring = "";

                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            reversedSubstring += substring[i];
                        }
                        message = string.Concat(message, reversedSubstring);
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine($"error");
                    }
                }
                else if (actionType == "ChangeAll")
                {
                    string substring = command.Split(":|:")[1];
                    string replacement = command.Split(":|:")[2];
                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
