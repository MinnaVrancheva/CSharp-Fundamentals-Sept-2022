namespace _23.HeroesOfCodeAndLogicVII
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, List<int>> heroesHealthMana = new Dictionary<string, List<int>>();
            
            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] heroInfo = Console.ReadLine().Split();
                string heroName = heroInfo[0];
                int manaPoints = int.Parse(heroInfo[1]);
                int healthPoints = int.Parse(heroInfo[2]);

                heroesHealthMana[heroName] = new List<int>();
                heroesHealthMana[heroName].Add(manaPoints);
                heroesHealthMana[heroName].Add(healthPoints);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string spell = command.Split(" - ")[0];
                string heroName = command.Split(" - ")[1];

                if (spell == "CastSpell")
                {
                    int mp = int.Parse(command.Split(" - ")[2]);
                    string spellName = command.Split(" - ")[3];

                    if (heroesHealthMana[heroName][1] >= mp)
                    {
                        heroesHealthMana[heroName][1] -= mp;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesHealthMana[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (spell == "TakeDamage")
                {
                    int damage = int.Parse(command.Split(" - ")[2]);
                    string attacker = command.Split(" - ")[3];
                    heroesHealthMana[heroName][0] -= damage;

                    if (heroesHealthMana[heroName][0] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesHealthMana[heroName][0]} HP left!");
                    }
                    else
                    {
                        heroesHealthMana.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (spell == "Recharge")
                {
                    int amount = int.Parse(command.Split(" - ")[2]);
                    int amountNeeded = 200 - heroesHealthMana[heroName][1];
                    heroesHealthMana[heroName][1] += amount;

                    if (heroesHealthMana[heroName][1] >= 200)
                    {
                        heroesHealthMana[heroName][1] = 200;
                        Console.WriteLine($"{heroName} recharged for {amountNeeded} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {amount} MP!");
                    }
                }
                else if (spell == "Heal")
                {
                    int amount = int.Parse(command.Split(" - ")[2]);
                    int amountNeeded = 100 - heroesHealthMana[heroName][0];
                    heroesHealthMana[heroName][0] += amount;

                    if (heroesHealthMana[heroName][0] >= 100)
                    {
                        heroesHealthMana[heroName][0] = 100;
                        Console.WriteLine($"{heroName} healed for {amountNeeded} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {amount} HP!");
                    }
                }
            }

            foreach (var (hero, value) in heroesHealthMana)
            {
                Console.WriteLine(hero);
                Console.WriteLine($"  HP: {value[0]}");
                Console.WriteLine($"  MP: {value[1]}");
            }
        }
    }
}
