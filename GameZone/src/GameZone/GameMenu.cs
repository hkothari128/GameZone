using System;
using System.Collections.Generic;
namespace GameZone
{
    class GameMenu
    {
        public static void Main()
        {
            List<String> games = new List<string>(){
                "SimoneSays",
                "SuspendPerson"
            };
            Console.Clear();
            Console.WriteLine("Select Game you want to play:");
            for (int i = 0; i < games.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{games[i]}");
            }

            Console.WriteLine($"Enter Choice(1-{games.Count}) or -1 to quit");
            int op = Convert.ToInt32(Console.ReadLine());
            if (op == 1)
            {
                var game = new SimoneSays();
                game.Play();
            }
            else if (op == 2)
            {
                Console.WriteLine("You have selected the SuspendPerson game");
                Console.WriteLine("Please enter a list of words(separated by ,) to be used as the guess word bank");
                String input = Console.ReadLine();
                var game = new SuspendPerson();
                game.Play(input.Split(','));
            }
            else if (op == -1)
            {
                Console.WriteLine("thanks for playing!");
            }

        }
    }
}
