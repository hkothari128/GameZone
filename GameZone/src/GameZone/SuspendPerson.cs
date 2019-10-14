using System;
using System.Collections.Generic;
namespace GameZone
{
    class SuspendPerson : Game
    {
        public void Play(String[] words)
        {
            List<String> guessWords;
            Console.WriteLine(words.Length + "" + words[0] + "<---words");
            if (words.Length == 1 && words[0] == "")
                guessWords = new List<string>(){
                "porcupine",
            };
            else guessWords = new List<string>(words);
            List<char> guessed = new List<char>();
            Random rnd = new Random();
            string guessWord = guessWords[rnd.Next(guessWords.Count)];


            int lives = 8;
            int matched = 0;
            HashSet<char> wordChars = new HashSet<char>(guessWord);
            printStats(guessWord, guessed, lives, matched);
            do
            {

                Console.WriteLine("Enter a letter to guess");
                char letter = Console.ReadKey().KeyChar;

                Console.WriteLine();

                if (!guessed.Contains(letter))
                {

                    if (guessWord.Contains(letter))
                        matched++;

                    else
                        lives--;
                    guessed.Add(letter);
                }
                printStats(guessWord, guessed, lives, matched);
            } while (lives > 0 && matched < wordChars.Count);


            if (lives == 0)
            {
                Console.WriteLine("\n\tYOU LOSE!");
            }
            else
            {
                Console.WriteLine("\n\tYOU WIN!");
            }
            menu(words);
        }

        void print(string guessWord, List<char> guessed)
        {
            foreach (char c in guessWord)
            {
                char printed = guessed.Contains(c) ? c : '_';
                Console.Write(printed + " ");
            }
            Console.WriteLine();
        }

        void printStats(string guessWord, List<char> guessed, int lives, int matched)
        {
            Console.Clear();
            Console.WriteLine("\tWELCOME TO SUSPEND PERSON GAME");
            guessed.Sort();
            Console.WriteLine("\n\nGuess this word:");
            print(guessWord, guessed);
            Console.WriteLine($"words guessed so far: [{string.Join(",", guessed.ToArray())}]");
            Console.WriteLine($"Lives:{lives}, Matched:{matched}");
        }

        void menu(String[] words)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1.Play game again");
            Console.WriteLine("2.Go back to game selection menu");
            int op = Convert.ToInt32(Console.ReadLine());
            if (op == 1)
            {
                Play(words);
            }
            else if (op == 2)
            {
                GameMenu.Main();
            }
        }
    }
}