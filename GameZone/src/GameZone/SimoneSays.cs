using System;
using System.Collections.Generic;
namespace GameZone
{
    class SimoneSays : Game
    {
        public void Play()
        {
            Console.WriteLine("Welcome to Simone says, a game about following orders. This is Version 0.1.\n");
            /* string[] tasks = new string[]{
                "Pick your nose",
                "Jump",
                "Waggle your finger",
                "Sleep"
            }; */
            List<string> tasks = new List<string>()
            {

            };
            tasks.Add("Pick your nose");
            tasks.Add("Jump");
            tasks.Add("Waggle your finger");
            tasks.Add("Sleep");

            string op = "y";
            do
            {
                Random rnd = new Random();
                int seed = rnd.Next(4);
                bool simoneSaidIt = (seed == 0);
                int commandSeed = rnd.Next(tasks.Count);
                string simoneSaidItString = simoneSaidIt ? "Simone says:" : "";
                Console.Write("***************\n" + simoneSaidItString);
                Console.WriteLine(tasks[commandSeed]);
                string response = Console.ReadLine();


                if (simoneSaidIt)
                {
                    if (response.ToLower() == tasks[commandSeed].ToLower())
                    {
                        Console.WriteLine("Good Job!");
                    }
                    else
                    {
                        Console.WriteLine($"No one said about {response}");
                    }
                }
                else
                {
                    if (response == "")
                    {
                        Console.WriteLine("Good job");
                    }
                    else if (response.ToLower() == tasks[commandSeed].ToLower())
                    {
                        Console.WriteLine("You fell for it");
                    }
                    else
                    {
                        Console.WriteLine("WHAT?");
                    }
                }


                Console.WriteLine("Continue?(y/n)");
                op = Console.ReadLine();
            } while (op == "y");
        }
    }
}
