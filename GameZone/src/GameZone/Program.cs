using System;
using System.Collections.Generic;

namespace GameZone
{
    class Program
    {
        static void Main(string[] args)
        {
            var mySpinner = new Loader();
            Console.Clear();
            Console.WriteLine("Select your game choices: \n1)JimsV \n2)NorthCodersV ");
            string selectedGameType = Console.ReadLine();

            // <----- For all the my written games -------

            if (selectedGameType == "1")
            {
                Console.Clear();
                Console.WriteLine("Jims Version of the games");
                mySpinner.SimplePercentageLoader();

                Console.Clear();
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

            // <----- For all the northCoder written games -------

            if (selectedGameType == "2")
            {
                Console.Clear();
                Console.WriteLine("NorthCoders Version of the games");
                mySpinner.SimplePercentageLoader();

                Console.Clear();
                Console.WriteLine("Select your game:");
                Console.WriteLine("1) SimoneSays \n2) SuspensionMan"); // add in list of games here
                string selectedGame = Console.ReadLine();

                if (selectedGame == "1")
                {
                    var myGame = new SimoneSays();
                    myGame.Play();
                }

                if (selectedGame == "2")
                {
                    string[] words = Console.ReadLine().Split(' ');
                    List<string> wordList = new List<string>();
                    foreach (string word in words)
                    {
                        wordList.Add(word);
                    }
                    var myGame = new SuspendPersonNC();
                    myGame.Play(wordList);
                }
            }
        }
    }
}