using System;
using System.Collections.Generic;

namespace GameZone
{

    public class SuspendPersonNC
    {
        public List<char> guesses = new List<char>();

        public void Play(List<string> wordList)
        {
            int seed = GetValidRandomSeed(wordList.Count);
            string mysteryWord = wordList[seed];
            Console.WriteLine("Welcome to the game, guess a letter");
            char letterGuess = Console.ReadKey().KeyChar;
            guesses.Add(letterGuess);

            foreach (char letter in mysteryWord)
            {
                char toPrint = GetCharacterToPrint(guesses, letter);
                Console.Write(toPrint);
            }
            Console.WriteLine("\nHave a guess at the word");
            string wordGuess = Console.ReadLine();
            if (wordGuess == mysteryWord)
            {
                Console.WriteLine("You got it, play again?");
            }
            else
            {
                Console.WriteLine("Nope, have another go?");
            }
            char prompt = Console.ReadKey().KeyChar;
            if (prompt == 'y')
            {
                Play(wordList);
            }
        }

        public int GetValidRandomSeed(int max)
        {
            Random rnd = new Random();
            int seed = rnd.Next(max);
            return seed;
        }

        public char GetCharacterToPrint(List<char> guesses, char letter)
        {
            if (guesses.Contains(letter)) return letter;
            return '-';
        }
    }
}