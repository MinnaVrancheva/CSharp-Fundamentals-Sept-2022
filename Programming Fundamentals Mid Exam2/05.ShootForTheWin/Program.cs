namespace _05.ShootForTheWin
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targetsArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();
            bool targetIsShot = false;
            int shotTargetsCount = 0;

            while (command != "End")
            {
                int targetIndex = int.Parse(command);

                if (targetIndex >= 0 && targetIndex < targetsArray.Length)
                {
                    if (targetsArray[targetIndex] == -1)
                    {
                        goto readKey;
                    }
                    else
                    {
                        int inputValue = targetsArray[targetIndex];
                        targetsArray[targetIndex] = -1;
                        targetIsShot = true;
                        shotTargetsCount++;

                        for (int i = 0; i < targetsArray.Length; i++)
                        {
                            if (targetsArray[i] > inputValue)
                            {
                                targetsArray[i] -= inputValue;
                            }
                            else if (targetsArray[i] <= inputValue && targetsArray[i] != -1)
                            {
                                targetsArray[i] += inputValue;
                            }
                        }
                    }
                }
                readKey:
                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {shotTargetsCount} -> {String.Join(" ", targetsArray)}");
        }
    }
}
