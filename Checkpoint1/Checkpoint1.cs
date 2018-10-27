using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint1 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("-----------------------------------------");
            Console.WriteLine ("Hello, Welcome to Rachael's Checkpoint 1!");
            Console.WriteLine ("-----------------------------------------");
            Console.WriteLine (" Count of Numbers % by 3 between 1 & 100 ");
            countMod3 ();
            Console.WriteLine ("-----------------------------------------");
            Console.WriteLine ("              Adding Numbers             ");
            Console.WriteLine ("-----------------------------------------");
            sumNum ();
            Console.WriteLine ("-----------------------------------------");
            Console.WriteLine ("           Finding Factorials            ");
            Console.WriteLine ("-----------------------------------------");
            factorial ();
        }
        /*1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
        Display the count on the console. */
        public static void countMod3 () {
            var count = 0;
            for (var i = 1; i <= 100; i++) {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine ("There are {0} numbers divisible by 3 between 1 and 100.", count);
        }
        /* 2- Write a program and continuously ask the user to enter a number or "ok" to exit.
        Calculate the sum of all the previously entered numbers and display it on the console.*/
        public static void sumNum () {
            //while program is not "ok" keep running
            var sum = 0;
            while (true) {
                Console.Write ("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine ();

                if (input.ToLower () == "ok")
                    break;

                sum += Convert.ToInt32 (input);
            }
            Console.WriteLine ("Sum of all numbers is: " + sum);
        }
        /*Write a program and ask the user to enter a number.
        Compute the factorial of the number and print it on the console.
        For example, if the user enters 5, the program should
        calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120. */
        public static void factorial () {
            Console.Write ("Enter a number: ");
            var number = Convert.ToInt32 (Console.ReadLine ());

            var factorial = 1;
            for (var i = 1; i <= number; i++)
                factorial *= i;

            Console.WriteLine ("{0}! = {1}", number, factorial);
        }
    }
}