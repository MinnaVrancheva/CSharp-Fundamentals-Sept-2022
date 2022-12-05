namespace _21.ActivationKeys
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawActivationKey = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Generate")
            {
                string actionType = command.Split(">>>")[0];

                if (actionType == "Contains")
                {
                    string substring = command.Split(">>>")[1];

                    if (rawActivationKey.Contains(substring))
                    {
                        Console.WriteLine($"{rawActivationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine($"Substring not found!");
                    }
                }
                else if (actionType == "Flip")
                {
                    string direction = command.Split(">>>")[1];
                    int startIndex = int.Parse(command.Split(">>>")[2]);
                    int endIndex = int.Parse(command.Split(">>>")[3]);
                    string subString = rawActivationKey.ToString()
                        .Substring(startIndex, endIndex - startIndex);

                    if (direction == "Upper")
                    {
                        subString = subString.ToUpper();
                    }
                    else if (direction == "Lower")
                    {
                        subString = subString.ToLower();
                    }

                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
                    rawActivationKey = rawActivationKey.Insert(startIndex, subString);
                    Console.WriteLine(rawActivationKey);
                }
                else if (actionType == "Slice")
                {
                    int startIndex = int.Parse(command.Split(">>>")[1]);
                    int endIndex = int.Parse(command.Split(">>>")[2]);
                    
                    rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(rawActivationKey);
                }
            }
            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }
    }
}
