using System;
using System.Threading;

namespace GameZone {
    class Loader {
        public void SimplePercentageLoader () {
            for (int i = 0; i <= 100; i++) {
                Console.Write ($"\rLoading: {i}%    ");
                Thread.Sleep (25);
            }
            Console.Write ("\rDone!");
            Console.Clear ();
        }

    }
}