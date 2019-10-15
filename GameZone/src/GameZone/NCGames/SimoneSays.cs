using System;
using System.Collections.Generic;

namespace GameZone
{
  class SimoneSays
  {
    public void Play()
    {
      Console.WriteLine("Welcome to Simone Says, a game about following orders. This is Version 0.1.");
      List<string> tasks = new List<string>();
      tasks.Add("Pick your nose");
      tasks.Add("Jump");
      tasks.Add("Waggle your finger");
      tasks.Add("Sleep");

      foreach (string command in tasks)
      {
        Random rnd = new Random();
        int seed = rnd.Next(4);
        bool simoneSaidIt = (seed == 0);

        switch (simoneSaidIt)
        {
          case true:
            Console.WriteLine($"Simone says {command}");
            break;
          case false:
            Console.WriteLine(command);
            break;
        }

        string response = Console.ReadLine();
        if (simoneSaidIt)
        {
          if (response == command)
          {
            Console.WriteLine("good job!");
          }
          else
          {
            Console.WriteLine($"nobody said anything about {response}");
          }
        }
        else
        {
          DateTime timeout = DateTime.Now.AddMilliseconds(3000);
          bool hasUserResponded = false;
          while (DateTime.Now < timeout)
          {
            if (Console.KeyAvailable)
            {
              Console.WriteLine("You fell for it stupid child");
              hasUserResponded = true;
            }
          }
          if (!hasUserResponded)
          {
            Console.Write("Good child, keep it up.");
          }
        }
      }
    }
  }
}