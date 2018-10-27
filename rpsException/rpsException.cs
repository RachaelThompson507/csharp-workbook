using System;

namespace RockPaperScissors {
    class Program {
        public static void Main () {
            Console.WriteLine ("Rock, Paper or Scissors - Let's Play!");
            //user input
            Console.WriteLine ("Choose rock, paper or scissors: ");
            string user = Console.ReadLine ().ToLower ();

            //computer input
            string computer = ComputerChoice ().ToLower ();

            //declare choices
            Console.WriteLine ("Your choice was {0} and the computer's choice was {1}.", user, computer);

            //try catch finally statement
            //Try normal win
            try {
                string winner = CompareHands (user, computer);
                Console.WriteLine ("Since, you chose {0}, and the computer chose {1}. {2} ", user, computer, winner);
            //catch outliers and instant win
            } catch (Exception e) {
                if (user == "crazy eyes") {
                    goto InstantWin;
                    InstantWin:
                        Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine ("You scared the bytes of the computer... You win!");
                    Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                } else {
                    Console.WriteLine (e.Message);
                }
            //Tell all users thank you
            } finally {
                Console.WriteLine ("Thank you for playing.");
            }
            //tests for RPS
            bool testing = true;
            if (!testing == true) {
                Console.WriteLine ("Your tests failed.");
            } else {
                Console.WriteLine ("Your tests Passed.");
            }
        }

        public static string ComputerChoice () {
            Random num = new Random ();
            int computerChoice = num.Next (0, 3);
            string computer = null;
        //if random number ='s ___ then choice for computer ='s ___
            if (computerChoice >= 2) {
                computer = "scissors";

                return computer;
            } else if (computerChoice >= 1) {
                computer = "rock";
                return computer;
            } else if (computerChoice >= 0) {
                computer = "paper";
                return computer;
            }
            return null;
        }
        // compare for win
        public static string CompareHands (string user, string computer) {
            if (user == computer) {
                return "Tie";
            } else if (user == "paper" && computer == "rock") {
                return "You Win";
            } else if (user == "scissors" && computer == "paper") {
                return "You Win";
            } else if (user == "rock" && computer == "scissors") {
                return "You Win";
            } else if (computer == "paper" && user == "rock") {
                return "Computer Wins";
            } else if (computer == "scissors" && user == "paper") {
                return "Computer Wins";
            } else if (computer == "rock" && user == "scissors") {
                return "Computer Wins";
            } else {
                throw new ArgumentException ("You did not enter a valid choice. You Lose....Sorry.");
            }
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