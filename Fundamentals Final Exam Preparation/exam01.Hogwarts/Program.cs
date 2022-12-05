namespace exam01.Hogwarts
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();
            string command;

            while ((command = Console.ReadLine()) != "Abracadabra")
            {
                string actionType = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];

                if (actionType == "Abjuration")
                {
                    string spellToUpper = spell.ToUpper();
                    spell = spellToUpper;
                    Console.WriteLine(spell);

                }
                else if (actionType == "Necromancy")
                {
                    string spellToLower = spell.ToLower();
                    spell = spellToLower;
                    Console.WriteLine(spell);
                }
                else if (actionType == "Illusion")
                {
                    int index = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
                    string letter = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2];

                    if (index < 0 || index > spell.Length - 1)
                    {
                        Console.WriteLine($"The spell was too weak.");
                    }
                    else
                    {
                        string letterToReplace = spell.Substring(index, 1);
                        spell = spell.Replace(letterToReplace, letter);
                        Console.WriteLine($"Done!");
                    }
                }
                else if (actionType == "Divination")
                {
                    string firstSub = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];
                    string secondSub = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2];

                    if (spell.Contains(firstSub))
                    {
                        spell = spell.Replace(firstSub, secondSub);
                        Console.WriteLine(spell);
                    }
                }
                else if (actionType == "Alteration")
                {
                    string substring = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];

                    if (spell.Contains(substring))
                    {
                        int subIndex = spell.IndexOf(substring);
                        spell = spell.Remove(subIndex, substring.Length);
                        Console.WriteLine(spell);
                    }
                }
                else
                {
                    Console.WriteLine($"The spell did not work!");
                }
            }
        }
    }
}
