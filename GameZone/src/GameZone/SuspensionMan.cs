using System;
using System.Threading;

namespace GameZone
{
    class SuspensionMan
    {
        static void Main(string[] args)
        {
            // Info about the game
            Console.WriteLine("Welcome to...");
            Thread.Sleep(1000); // adding in Suspense for the player
            Console.WriteLine("...Suspension Man");

            // a list of hard coded words to begin with
            string[] words = new string[]{
                "Fox", "Rabbit", "Fish"
            };

            // Game will randomly pick one of the words
            Random rnd = new Random();
            int wordSeed = rnd.Next(words.Length);
            string selectedWord = words[wordSeed];
            
            Console.WriteLine("");
            Console.WriteLine($"The selected word is...{selectedWord}");
            // the game will tell you the length of the word
            // player enters a letter 
            // game says if the letter is present: 
            // - if correct where abouts in the word/ how many times
            // game will ask if the palyer wants to make a guess:
            // - if not loop around again
            // player can enter the word 
            // game will say if correct or not
            // game will ask to paly again
        }
    }
}