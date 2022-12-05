namespace _13.ThePianist
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPianoPieces = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> pieceComposerKey = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfPianoPieces; i++)
            {
                string input = Console.ReadLine();
                string piece = input.Split('|')[0];
                string composer = input.Split('|')[1];
                string key = input.Split("|")[2];

                List<string> composerKey = new List<string>();
                pieceComposerKey.Add(piece, composerKey);
                pieceComposerKey[piece].Add(composer);
                pieceComposerKey[piece].Add(key);
            }
            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string actionType = command.Split('|')[0];

                if (actionType == "Add")
                {
                    string piece = command.Split('|')[1];
                    string composer = command.Split('|')[2];
                    string key = command.Split("|")[3];

                    if (!pieceComposerKey.ContainsKey(piece))
                    {
                        List<string> composerKey = new List<string>();
                        composerKey.Add(composer);
                        composerKey.Add(key);
                        pieceComposerKey.Add(piece, composerKey);
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                }
                else if (actionType == "Remove")
                {
                    string piece = command.Split('|')[1];

                    if (!pieceComposerKey.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    else
                    {
                        pieceComposerKey.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                }
                else if (actionType == "ChangeKey")
                {
                    string piece = command.Split('|')[1];
                    string newKey = command.Split("|")[2];

                    if (!pieceComposerKey.ContainsKey(piece))
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                    else
                    {
                        pieceComposerKey[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                }
            }
            foreach (var (piece, value) in pieceComposerKey)
            {
                Console.WriteLine($"{piece} -> Composer: {value[0]}, Key: {value[1]}");
            }
        }
    }
}
