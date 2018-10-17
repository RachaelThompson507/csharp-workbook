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
            string computer = ComputerChoice ();

            //declare choices
            Console.WriteLine ("Your choice was {0} and the computer's choice was {1}.", user, computer);

            //Compare choices
            //CompareHands (user, computer);

            //assign return
            string winner = CompareHands(user,computer);

            //gameEvent action
            Console.WriteLine ("The you choose {0}, the computer choose {1}. {2} ", user, computer, winner);

            // bool tests = true;
            // if()
            // {

            // }

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
                Console.WriteLine(computerChoice);
                return computer;
            } else if (computerChoice >= 1) {
                computer = "rock";
                Console.WriteLine(computerChoice);
                return computer;
            } else if (computerChoice >= 0) {
                computer = "paper";
                Console.WriteLine(computerChoice);
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
            }
            return "gameError";
        }
        // public static bool tests()
        // {
        //     return   ;
        // }
        
        // public static bool test1()
        // {
        //     string user = "rock";
        //     string computer = "rock";
        //     if( user == computer && gameEvent = "Tie")
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }
        /*
        Going to use my own method- keeping for example:
        returns true if all tests pass
        returns false if at least 1 test fails
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
        }*/
    }
}