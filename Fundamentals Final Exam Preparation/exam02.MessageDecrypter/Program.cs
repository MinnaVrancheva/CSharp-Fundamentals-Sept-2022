namespace exam02.MessageDecrypter
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(\%|\$)(?<tag>[A-Z][a-z]{2,})\1:\s{1}\[(?<group1>\d+)\]\|\[(?<group2>\d+)\]\|\[(?<group3>\d+)\]\|$";
            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string input = Console.ReadLine();
                Match validMessages = Regex.Match(input, pattern);

                if (!validMessages.Success)
                {
                    Console.WriteLine($"Valid message not found!");
                }
                else
                {
                    string tag = validMessages.Groups["tag"].Value;
                    int group1 = int.Parse(validMessages.Groups["group1"].Value);
                    int group2 = int.Parse(validMessages.Groups["group2"].Value);
                    int group3 = int.Parse(validMessages.Groups["group3"].Value);

                    char letter1 = (char)group1;
                    char letter2 = (char)group2;
                    char letter3 = (char)group3;
                    
                    string decryptedMessage = string.Concat(letter1, letter2, letter3);
                    Console.WriteLine($"{tag}: {decryptedMessage}");
                }
            }
        }
    }
}
