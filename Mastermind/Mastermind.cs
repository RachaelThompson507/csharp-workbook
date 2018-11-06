using System;
using System.Collections.Generic;
using System.Collections;

namespace Mastermind {
    class Program {
        public static void main (String[] args) {

        }
        class Game {
            List<Row> guesses;
            String [] theAnswer;
            public Game(){
                theAnswer = new String[] {"a", "b", "c", "d"};
                guesses = new List<Row>();
            }
            public void run(){
                //display current guesses
                displayAllGuess();
                // ask for next guess
                Row newGuess = getUserGuess();
                //add guess to list
                guesses.Add(newGuess);
                //evaluate guess check win
                //no win- ask for another guess
                // if win - return
            }
            public Row getUserGuess(){
                Console.WriteLine("Enter your guess as 4 letters:");
                String guess = Console.ReadLine();
                guess = guess.ToLower();
                guess = guess.Trim();
                //make sure the user really enters in 4 letters
                if (guess.Length != 4){
                    throw new Exception ("Guess should be 4 letters");
                }
                //create a row object from the users input
                Row theNewRow = new Row(guess);
                return theNewRow;
            }

            public void displayAllGuess(){
                foreach(Row guess in guesses){
                    Console.WriteLine(guess.toString());
                }
            }
        }
        class Row {
            //lists of 4 balls being held by this row
            public Ball[] balls { get; }
            // creates a new row with the 4 balls passed in
            public Row (String letters) {
                if(letters.Length != 4){
                    throw new Exception ("Row constructor takes in a string of size 4.");
                }
                balls = new Ball[4];
                //char [] temp = letters.ToCharArray();
                for (int i = 0; i<4; i++){
                    balls[i] = new Ball(letters[i].ToString());
                }
            }
            //returns a string rep of ball
            public string toString() {
                String formatted = " ";
                foreach (Ball ball in balls){
                    formatted += ball.ColorLetter+" ";
                }
                return formatted.Trim();
            }
        }
        class Ball {
            public string ColorLetter { get; }
            //sets letter for ball
            public Ball (String ColorLetter) {
                this.ColorLetter = ColorLetter;
            }
        }
    }
}