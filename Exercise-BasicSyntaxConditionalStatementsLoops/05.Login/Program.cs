namespace _05.Login
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            
            for (int i = username.Length - 1; i >= 0 ; i--)
            {
                password += username[i];
            }

            string entPass = Console.ReadLine();
            int counter = 0;
            while (entPass != password)
            {
                counter++;
                if (counter > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine($"Incorrect password. Try again.");
                entPass = Console.ReadLine();
            }
            if (password == entPass)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
