using System;
using System.Text.RegularExpressions;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list of words that the user has to guess
            string[] words = { "csharp", "visualstudio", "language", "array", "variable", "parsing", "constant" };

            //to verify that the player's input is within 'a' and 'z'
            var validCharacters = new Regex("^[a-z]$");

            //find a random number
            int myRandomNumber = new Random().Next(0, words.Length - 1);

            //pick a random word from the array
            string wordToGuess = words[myRandomNumber];

            //number of lives
            int lives = 3;

            //list of letters submitted by the player
            List<string> letters = new();

            //as long as the player has lives left, the game continues
            while (lives != 0)
            {
                //counter of characters left to guess
                int charactersLeft = 0;

                //loop through all the characters of the chosen word
                foreach (char character in wordToGuess)
                {
                    var letter = character.ToString();

                    if (letters.Contains(letter))
                    {
                        Console.Write(letter);
                    }
                    else
                    {
                        Console.Write("_");

                        charactersLeft++;
                    }
                }
                Console.WriteLine(String.Empty);

                if (charactersLeft == 0)
                {
                    break;
                }

                Console.Write("Type in a letter: ");

                var key = Console.ReadKey().Key.ToString().ToLower();

                Console.WriteLine(String.Empty);

                if (!validCharacters.IsMatch(key))
                {
                    Console.WriteLine($"The letter {key} is invalid. Try again.");
                    continue;
                }

                if (letters.Contains(key))
                {
                    Console.WriteLine("You have already entered this letter!");
                    continue;
                }

                letters.Add(key);

                if (!wordToGuess.Contains(key))
                {
                    lives--;

                    if (lives > 1)
                    {
                        Console.WriteLine($"The letter {key} is not in the word to guess. You have {lives} lives left");

                    }
                    else if (lives == 1)
                    {
                        Console.WriteLine($"The letter {key} is not in the word to guess. You have 1 life left");
                    }
                }
                if (lives > 0)
                {
                    Console.WriteLine($"You have {lives} lives left!");
                }
                else
                {
                    Console.WriteLine($"You have lost! The word was {wordToGuess}.");
                }
            }
           
        }
    }
}