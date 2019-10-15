using System;
// using System.Collections.Generic;

namespace GameZone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Select your game choices: \nNorthCodersV \nJimsV");
            Console.WriteLine("Select your game:");
            Console.WriteLine("1) SimonSays \n2) SuspensionMan"); // add in list of games here

            string selectedGame = Console.ReadLine();
            if (selectedGame == "1")
            {
                Console.WriteLine("Simon picked");
                var myGame = new SimonSays();
                myGame.Play(args);
            }
            if (selectedGame == "2")
            {
                var myGame = new SuspensionManJims();
                myGame.Play();
            }
           






        }
    }
}