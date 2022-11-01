namespace _03.ChatLogger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> commands = new List<string>();
                
            string command = Console.ReadLine();

            while (command != "end")
            {
                string command1 = command.Split()[0];
                string message = command.Split()[1];

                if (command1 == "Chat")
                {
                    commands.Add(message);
                }
                else if (command1 == "Delete")
                {
                    if (commands.Contains(message))
                    {
                        commands.Remove(message);
                    }
                }
                else if (command1 == "Edit")
                {
                    string editedVersion = command.Split()[2];
                    if (commands.Contains(message))
                    {
                        commands.Insert(commands.IndexOf(message), editedVersion);
                        commands.Remove(message);
                    }
                }
                else if (command1 == "Pin")
                {
                    if (commands.Contains(message))
                    {
                        commands.Add(message);
                        commands.RemoveAt(commands.IndexOf(message));
                    }
                }
                else if (command1 == "Spam")
                {
                    List<string> messages = new List<string>(command.Split(' '));
                    for (int i = 1; i < messages.Count; i++)
                    {
                        commands.Add(messages[i]);
                    }
                    
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i < commands.Count; i++)
            {
                Console.WriteLine(commands[i]);
            }
        }
    }
}
