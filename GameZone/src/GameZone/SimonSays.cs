/*
using System;
using System.Collections.Generic;

namespace GameZone
{
    class SimonSays
    {
        static void Main(string[] args)
        {
            // print info about the game 
            Console.WriteLine("Welcome to your new game of Simon says! This is version 0.1 of the game.");

            // define a 'list' of tasks
            // string[] tasks = new string[]{
            //     "Pick your nose",
            //     "Jump",
            //     "Wiggle your finger",
            //     "Sleep"
            // };

            List<string> tasks = new List<string>();
            tasks.Add("Nose");
            tasks.Add("Eyes");
            tasks.Add("Mouth");
            tasks.Add("Ears");


            // for (int i = 0; i < tasks.Count; i++){
            // }

            // foreach(string command in tasks){
            // };

            // ramdomise if Simon says or not 
            Random rnd = new Random();
            int seed = rnd.Next(4);
            bool simonSaidIt = (seed == 0);





            // choose a cmd at random
            int commandSeed = rnd.Next(tasks.Count);

            string command = tasks[commandSeed];

            switch (simonSaidIt)
            {
                case true:
                    Console.WriteLine($"Simon says {command}");
                    break;

                case false:
                    Console.WriteLine(command);
                    break;
            }

            string response = Console.ReadLine();

            if (simonSaidIt)
            {
                if (response == command)
                {
                    Console.WriteLine("Well Done");
                }

                else
                {
                    Console.WriteLine($"nobody said anything about {response}");
                }
            }

            else
            {
                DateTime timeOut = DateTime.Now.AddMilliseconds(5000);
                bool hasUserResponded = false;
                while (DateTime.Now < timeOut)
                {
                    if (Console.KeyAvailable)
                    {
                        Console.WriteLine("You loose");
                    }
                }
                if (!hasUserResponded)
                {
                    Console.WriteLine("Good work");
                }
            }
            Console.WriteLine("Play again Y/N");
            string playAgain = Console.ReadLine();

            if (playAgain == "y")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Bye Bye");
            }

            // take input from the user 
            // handle outcones: 
            //-input was incorrect 
            //-input was correct but simon said it
            //-wait to move to the next one 
            // feedback to the user 
            // ask to contuine 
            // Thread.Sleep(3000)
        }
    }
}

// Console.WriteLine("Enter a name to progress:");
// string name = Console.ReadLine();
// Console.WriteLine($"Hello {name}");

// if (args.Length >= 1)
// {
//     // Console.WriteLine($"Hello {args[0]}");

// }
// else
// {
//     Console.WriteLine($"Hello Person");
// }


// try
// {
//     Console.WriteLine($"Hello {args[0]}");
// }

// catch (Exception)
// {
//     Console.WriteLine("You didnt give me a name");
// }


 */