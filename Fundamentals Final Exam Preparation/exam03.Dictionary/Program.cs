namespace exam03.Dictionary
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> wordsDefinitions = new Dictionary<string, List<string>>();
            string command1 = Console.ReadLine();
            string[] wordAndDefinition = command1.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < wordAndDefinition.Length; i++)
            {
                string[] wordAndDefinitions = wordAndDefinition[i].Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string word = wordAndDefinitions[0];
                string definition = wordAndDefinitions[1];
                
                    if (!wordsDefinitions.ContainsKey(word))
                    {
                        wordsDefinitions[word] = new List<string>();
                    }
                        
                    wordsDefinitions[word].Add(definition);
            }

            string teachersCommands = Console.ReadLine();
            string[] singleCommand = teachersCommands.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

            string command2 = Console.ReadLine();

            if (command2 == "Test")
            {
                foreach (string word in singleCommand)
                {
                    if (wordsDefinitions.ContainsKey(word))
                    {
                        Console.WriteLine($"{word}:");
                        foreach (string value in wordsDefinitions[word])
                        {
                            Console.WriteLine($" -{value}");
                        }
                            
                    }
                }
            }
            else if (command2 == "Hand Over")
            {
                List<string> keys = new List<string>();
                foreach (string key in wordsDefinitions.Keys)
                {
                    keys.Add(key);
                }
                Console.WriteLine(String.Join(" ", keys));
            }
        }
    }
}
