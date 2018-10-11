using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter hand 2:");
            string hand2 = Console.ReadLine().ToLower();
            Console.WriteLine(CompareHands(hand1, hand2));

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        //return 1 if hand 1 wins
        //returns 2 if hand 2 wins
        // returns 0 if no one wins
        public static int CompareHands(string hand1, string hand2)
        {
            // Your code here
            return hand1 + ' ' + hand2;
        }
        //returns true if all tests pass
        //returns false if at least 1 test fails
        public static bool tests()
        {
            return
            //CompareHands("Paper", "Paper") == 0 &&
            //CompareHands("Rock", "Rock") == 0 &&
            //CompareHands("Scissors", "Scissors") == 0 &&
            //CompareHands("Paper", "Rock") == 1 &&
            //CompareHands("Paper", "Scissors") == 2 &&
            //CompareHands("Rock", "Paper") == 2 &&
            //CompareHands("Rock", "Scissors") == 1 &&
            //CompareHands("Scissors", "Paper") == 1 &&
            //CompareHands("Scissors", "Rock") == 2 ;
        }
    }
}
