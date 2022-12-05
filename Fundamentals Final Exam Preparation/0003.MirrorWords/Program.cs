namespace _0003.MirrorWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@|#)(?<wordOne>[A-Za-z]{3,})(\1)(\1)(?<wordTwo>[A-Za-z]{3,})(\1)";
            string input = Console.ReadLine();
            MatchCollection validPairs = Regex.Matches(input, pattern);

            if (validPairs.Count == 0)
            {
                Console.WriteLine($"No word pairs found!");
                Console.WriteLine($"No mirror words!");
            }
            else
            {
                Console.WriteLine($"{validPairs.Count} word pairs found!");
                List<string> mirrorWords = new List<string>();

                foreach (Match validPair in validPairs)
                {
                    var firstWord = validPair.Groups["wordOne"].Value;
                    var secondWord = validPair.Groups["wordTwo"].Value;
                    string reversed = new string(firstWord.Reverse().ToArray());
                    var palindrome = secondWord == reversed;

                    if (palindrome)
                    {
                        string finalString = $"{firstWord} <=> {secondWord}";
                        mirrorWords.Add(finalString);
                    }
                }

                if (mirrorWords.Count == 0)
                {
                    Console.WriteLine($"No mirror words!");
                }
                else
                {
                    Console.WriteLine($"The mirror words are:");
                    Console.WriteLine(string.Join(", ", mirrorWords));
                }
            }
        }
        
    }
}
