namespace _0002.TheImitationGame
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string messageToDecifer = Console.ReadLine();
            //StringBuilder finalMessage = new StringBuilder(messageToDecifer);
            string command;

            while ((command = Console.ReadLine()) != "Decode")
            {
                string actionType = command.Split('|')[0];

                if (actionType == "Move")
                {
                    int numberOfLetters = int.Parse(command.Split('|')[1]);
                    string substring = messageToDecifer.Substring(0, numberOfLetters);
                    messageToDecifer = messageToDecifer.Remove(0, numberOfLetters);
                    messageToDecifer += substring;
                }
                else if (actionType == "Insert") 
                {
                    int index = int.Parse(command.Split('|')[1]);
                    string value = command.Split('|')[2];
                    messageToDecifer = messageToDecifer.Insert(index, value);
                }
                else if (actionType == "ChangeAll")
                {
                    string substring = command.Split('|')[1];
                    string replacement = command.Split('|')[2];
                    messageToDecifer = messageToDecifer.Replace(substring, replacement);
                }
            }
            Console.WriteLine($"The decrypted message is: {messageToDecifer}");
        }
    }
}
