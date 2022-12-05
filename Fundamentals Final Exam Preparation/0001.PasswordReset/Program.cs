namespace _0001.PasswordReset
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string initialPassword = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                //string[] action = command.Split();
                string actionType = command.Split()[0];

                if (actionType == "TakeOdd")
                {
                    string currentPass = string.Empty;
                    for (int i = 0; i < initialPassword.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            currentPass += initialPassword[i];
                        }
                    }
                    initialPassword = currentPass;
                    Console.WriteLine(initialPassword);
                }
                else if (actionType == "Cut")
                {
                    int index = int.Parse(command.Split()[1]);
                    int length = int.Parse(command.Split()[2]);
                    initialPassword = initialPassword.Remove(index, length);
                    Console.WriteLine(initialPassword);
                }
                else if (actionType == "Substitute")
                {
                    string substring = command.Split()[1];
                    string substitute = command.Split()[2];

                    if (initialPassword.Contains(substring))
                    {
                        initialPassword = initialPassword.Replace(substring, substitute);
                        Console.WriteLine(initialPassword);
                    }
                    else
                    {
                        Console.WriteLine($"Nothing to replace!");
                    }
                }
            }
            Console.WriteLine($"Your password is: {initialPassword}");
        }
    }
}
