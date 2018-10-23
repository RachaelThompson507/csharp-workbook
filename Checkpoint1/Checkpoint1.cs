using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint1 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("-----------------------------------------");
            Console.WriteLine ("Hello, Welcome to Rachael's Checkpoint 1!");
            Console.WriteLine ("-----------------------------------------");
            countMod3 ();
        }
        //program to count how many numbers between 1 & 100 are %3
        //display the count by calling fx in main w/ writeline
        public static void countMod3 () {
            List<int> countMod3 = new List<int> ();
            int count = 0;
            for (int i = 1; i <= 100; i++) {
                if (i % 3 == 0) {
                    countMod3.Add (count++);
                }
            }
            Console.WriteLine ("The number of times a number between 1 and 100 was divisible by 3 \nwithout a remainder was {0}.", countMod3.Count);
        }
    }
}