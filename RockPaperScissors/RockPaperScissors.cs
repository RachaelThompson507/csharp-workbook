using System;

namespace RockPaperScissors {
    class Program {
        public static void Main () {
            //declare var
            //string gameEvent = " ";
            //string gameError = "An Error has occured.";
            //start
            Console.WriteLine ("Rock, Paper or Scissors - Let's Play!");
            //user input
            Console.WriteLine ("Choose rock, paper or scissors: ");
            string user = Console.ReadLine ().ToLower ();

            //computer input
            string computer = ComputerChoice ().ToLower ();

            //declare choices
            Console.WriteLine ("Your choice was {0} and the computer's choice was {1}.", user, computer);

            /*
            No being used anymore, for reference:
            Compare choices
            CompareHands (user, computer);
            */

            //assign return
            string winner = CompareHands (user, computer);

            //gameEvent action
            Console.WriteLine ("Since, you chose {0}, and the computer chose {1}. {2} ", user, computer, winner);

            bool testing = true;
            if (!testing == true) {
                Console.WriteLine ("Your tests failed.");
            } else {
                Console.WriteLine ("Your tests Passed.");
            }

            /*
            This does not work for me:
            Console.WriteLine("Enter hand 2:");
            string hand2 = Console.ReadLine().ToLower();
            Console.WriteLine(CompareHands(hand1, hand2));
            */

            // leave this command at the end so your program does not close automatically
            //Console.ReadLine ();
        }

        public static string ComputerChoice () {
            Random num = new Random ();
            int computerChoice = num.Next (0, 3);
            string computer = null;
            //if random number ='s ___ then choice for computer ='s ___
            if (computerChoice >= 2) {
                computer = "scissors";
                //Console.WriteLine (computerChoice);
                return computer;
            } else if (computerChoice >= 1) {
                computer = "rock";
                //Console.WriteLine (computerChoice);
                return computer;
            } else if (computerChoice >= 0) {
                computer = "paper";
                //Console.WriteLine (computerChoice);
                return computer;
            }
            return null;
        }
        // compare for win
        public static string CompareHands (string user, string computer) {
            if (user == computer) {
                //gameEvent = "Tie";
                return "Tie";
            } else if (user == "paper" && computer == "rock") {
                //gameEvent = "You Win";
                return "You Win";
            } else if (user == "scissors" && computer == "paper") {
                //gameEvent = "You Win";
                return "You Win";
            } else if (user == "rock" && computer == "scissors") {
                //gameEvent = "You Win";
                return "You Win";
            } else if (computer == "paper" && user == "rock") {
                //gameEvent = "Computer Wins";
                return "Computer Wins";
            } else if (computer == "scissors" && user == "paper") {
                //gameEvent = "Computer Wins";
                return "Computer Wins";
            } else if (computer == "rock" && user == "scissors") {
                //gameEvent = "Computer Wins";
                return "Computer Wins";
            } else {
                return "WHO KNOWS???";
            }
            //return "gameError";
        }

        // Going to use my own method- keeping for example:
        // returns true if all tests pass
        // returns false if at least 1 test fails
        public static bool tests (bool testing) {
            return
            CompareHands ("Paper", "Paper") == "Tie" &&
                CompareHands ("Rock", "Rock") == "Tie" &&
                CompareHands ("Scissors", "Scissors") == "Tie" &&
                CompareHands ("Paper", "Rock") == "You Win" &&
                CompareHands ("Paper", "Scissors") == "Computer Wins" &&
                CompareHands ("Rock", "Paper") == "Computer Wins" &&
                CompareHands ("Rock", "Scissors") == "You Win" &&
                CompareHands ("Scissors", "Paper") == "You Win" &&
                CompareHands ("Scissors", "Rock") == "Computer Wins";
        }
    }
}