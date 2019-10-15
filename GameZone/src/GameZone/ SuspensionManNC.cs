using System;
using System.Collections.Generic;

namespace GameZone
{
    class SuspendPersonNC
    {
        public List<char> guesses = new List<char>();
        public void Play(List<string> wordList)
        {
            Random rnd = new Random();
            int newRnd = rnd.Next(wordList.Count);
            string mysteryWord = wordList[newRnd];
            Console.WriteLine("Welcome to the game, guess a letter");
            char letterGuess = Console.ReadKey().KeyChar;
            guesses.Add(letterGuess);
            foreach (char letter in mysteryWord)
            {
                if (guesses.Contains(letter))
                {
                    Console.Write(letter);
                }
                else
                {
                    Console.Write('-');
                }
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
    }
}