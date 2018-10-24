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
            sumNum();
        }
        /*1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
        Display the count on the console. */
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
        /* 2- Write a program and continuously ask the user to enter a number or "ok" to exit.
        Calculate the sum of all the previously entered numbers and display it on the console.*/
        public static void sumNum () {
            while (Console.ReadLine() != "ok") {
                Console.WriteLine("Please enter a number or type 'ok' to exit.");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a number or type 'ok' to exit.");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(" {0} + {1} = {2} ", num1, num2, num1+num2);
            }
        }
        /*Write a program and ask the user to enter a number.
        Compute the factorial of the number and print it on the console.
        For example, if the user enters 5, the program should
        calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120. */
    }
}