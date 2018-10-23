using System;

namespace Checkpoint1 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
            countMod3();
        }
        //program to count how many numbers between 1 & 100 are %3
        //display the count by calling fx in main w/ writeline
        public static void countMod3 () {
            for (int i = 1; i <= 100; i ++) {
                if (i%3 == 0) {
                    //Console.WriteLine(i);
                }
            }
        }
    }
}