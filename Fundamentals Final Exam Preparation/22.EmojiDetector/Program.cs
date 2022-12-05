namespace _22.EmojiDetector
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\:\:|\*\*)(?<emoji>[A-Z][a-z]{2,})(\1)";

            string input = Console.ReadLine();
            long coolTreshold = 1;

            foreach (var ch in input)
            {
                if (char.IsDigit(ch))
                {
                    long digit = (long)ch - 48;
                    coolTreshold *= digit;
                }
            }

            Regex validEmoji = new Regex(pattern);
            MatchCollection validEmojis = validEmoji.Matches(input);

            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{validEmojis.Count} emojis found in the text. The cool ones are:");

            foreach (Match match in validEmojis)
            {
                string emojiValue = match.Groups["emoji"].Value;
                long emojiCoolness = 0;
                string emojiChar = match.Groups[1].Value;

                foreach (char ch in emojiValue)
                {
                    emojiCoolness += (int)ch;
                }

                if (emojiCoolness >= coolTreshold)
                {
                    Console.WriteLine($"{emojiChar}{emojiValue}{emojiChar}");
                }
            }
        }
    }
}
