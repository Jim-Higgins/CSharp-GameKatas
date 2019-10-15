using System;
using System.Threading;

namespace GameZone
{
    class SuspensionManJims
    {
        public void Play()
        {
            // Info about the game
            Console.Clear();
            Console.WriteLine("Welcome to...");
            Thread.Sleep(1000); // adding in Suspense for the player
            Console.WriteLine("...Suspension Man");

            // A list of hard coded words to begin with
            string[] words = new string[]{
                "fox", "rabbit", "fish"
            };

            // Game will randomly pick one of the words
            Random rnd = new Random();
            int wordSeed = rnd.Next(words.Length);
            string selectedWord = words[wordSeed];

            // The game will tell you the length of the word
            Console.WriteLine("Thinking up a word for you...");
            // Fancy percentage laoding
            var mySpinner = new Loader();
            mySpinner.SimplePercentageLoader();
            Console.WriteLine($"The selected word is made up of {selectedWord.Length} letters.");

            // Player enters a letter 
            Console.WriteLine("Enter a letter to guess if it is in my word:");
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            Console.WriteLine("\nYou pressed {0}", keyPressed.KeyChar);

            // Game says if the letter is present:
            Console.WriteLine($"Hhhm let me check that {keyPressed.KeyChar} is in my word...");
            Thread.Sleep(1000);

            if (selectedWord.IndexOf(keyPressed.KeyChar) != -1)
            {
                Console.WriteLine($"The word I am thinking off does contain the letter {keyPressed.KeyChar}");
            }
            else
            {
                Console.WriteLine($"Nope that {keyPressed.KeyChar} is not in my word");
            }

            // - if correct where abouts in the word/ how many times
            // need to add this code in 

            // game will ask if the palyer wants to make a guess:
            // - if not loop around again
            Console.WriteLine("Would you like to take a guess yet at my word? ");
            Console.WriteLine("Y/N ");
            string takeAGuess = Console.ReadLine();
            if (takeAGuess == "y")
            {
                Console.WriteLine("Please enter your guess: ");
                string guessedWord = Console.ReadLine();
                if (guessedWord == selectedWord)
                {
                    Console.WriteLine("How did you do that? You won!");
                }
                else
                {
                    Console.WriteLine("Oh no you got it wrong");
                }
            }
            else
            {
                Console.WriteLine("Thats a shame, as now I win HAHAHA");
            }
            // player can enter the word 
            // game will say if correct or not
            // game will ask to paly again
        }


        // Code for the loader

    }
}