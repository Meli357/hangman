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
            }
        }
    }
}