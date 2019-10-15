using System;

namespace GameZone {
    class Program {
        static void Main (string[] args) {
            Console.Clear ();
            Console.WriteLine ("Select your game choices: \n1)JimsV \n2)NorthCodersV ");
            string selectedGameType = Console.ReadLine ();
            if (selectedGameType == "1") {
                Console.Clear ();
                Console.WriteLine ("Jims Version of the games");
                var mySpinner = new Loader ();
                mySpinner.SimplePercentageLoader ();

                Console.Clear ();
                Console.WriteLine ("Select your game:");
                Console.WriteLine ("1) SimonSays \n2) SuspensionMan"); // add in list of games here
                string selectedGame = Console.ReadLine ();
                if (selectedGame == "1") {
                    Console.WriteLine ("Simon picked");
                    var myGame = new SimonSays ();
                    myGame.Play (args);
                }
                if (selectedGame == "2") {
                    var myGame = new SuspensionManJims ();
                    myGame.Play ();
                }

            }
            if (selectedGameType == "2") {
                Console.Clear ();
                Console.WriteLine ("NorthCoders Version of the games");

            }
        }
    }
}