using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Files {
    class Program {
        static void Main (string[] args) {
            //variables
            bool play = true;
            Console.WriteLine (" ~~~ ---> Hangman <--- ~~~ ");
            Thread.Sleep(2000);
            //while loop so you can keep playing.
            while (play){
                Console.WriteLine(@"Do you want to play? use ""y"" to play or ""n"" to exit.");
                string input = Console.ReadLine().ToLower().Trim();
                //if you want to keep playing or are done
                if (input == "y"){
                    play = true;
                } else if (input == "n"){
                    play = false;
                    break;
                }
                //instantiate game Logic to play the game through the guess game method.
                //if there is a handled error this will display the error.
                try{
                    GameLogic.GuessGame();
                } catch (Exception e) {
                    Console.WriteLine (e.Message);
                }
            }
            
            //debug || test
            //Console.WriteLine (Files.generateRandom());
            //Console.WriteLine (GameLogic.DisplayWord ());
            //GameLogic.GuessGame();
        }
    }
    class Files {
        //path of the file to be used
        public static string file { get; private set; }
        //word from file
        public string word { get; set; }
        //generates a random word by reading the file since all words are on their own lines
        public static string generateRandom () {
            string file = @"WordList.txt";
            string[] lines = File.ReadAllLines (file);
            Random r = new Random ();
            int line = r.Next (0, lines.Length - 1);
            string word = lines[line].ToLower ();
            return word;
        }
        // public Files (string file, string word) {
        //     generateRandom ();
        //     Files.file = @"WordList.txt";
        //     this.word = word;
        // }
    }
    class GameLogic {
        public static void GuessGame () {
            //generate random word from list
            string wordToGuess = Files.generateRandom ();
            //This console.writeline is for debugging/validating the function works as intended.
            Console.WriteLine ($"The word you are trying to guess has {wordToGuess.Length} letters.");
            Console.WriteLine ();
            //create display to user
            StringBuilder displayWord = new StringBuilder (wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++) {
                displayWord.Append ("_");
            }
            string display = displayWord.ToString ();
            Console.WriteLine (display);
            Console.WriteLine ();
            //move on to game action
            string wordGuessing = wordToGuess.ToLower ();
            List<char> correctLetter = new List<char> ();
            List<char> incorrectLetter = new List<char> ();
            // number of lives based on incorrect letters
            int lives = 7;
            //bool for win state
            bool win = false;
            // revealed letters starts at 0
            int letterRevealed = 0;

            string input;
            char guess;

            //while loop for gamePlay
            while (!win && lives > 0) {
                Console.WriteLine ("Guess a letter.");
                input = Console.ReadLine ().ToLower ();
                guess = input[0];
                // if conditions for if letter already guessed or not
                if (correctLetter.Contains (guess)) {
                    throw new Exception ($"The letter {guess} has already been guessed and was correct.");

                } else if (incorrectLetter.Contains (guess)) {
                    throw new Exception ($"The letter {guess} has already been guessed and was incorrect.");

                } else {
                    if (wordGuessing.Contains (guess)) {
                        correctLetter.Add (guess);
                        for (int i = 0; i < wordGuessing.Length; i++) {
                            if (wordGuessing[i] == guess) {
                                displayWord[i] = wordGuessing[i];
                                letterRevealed++;
                            }
                        }
                        if (letterRevealed == wordGuessing.Length) {
                            win = true;
                        }
                    } else {
                        incorrectLetter.Add (guess);
                        Console.WriteLine ($"There is not {guess}, in this word.");
                        lives--;
                    }
                    Console.WriteLine (displayWord.ToString ());
                }
                if (win) {
                    Console.WriteLine ("You win!");
                } else if (!win && lives <=0){
                    Console.WriteLine ($"You lost. The word is {wordGuessing}");
                } else {
                    Console.WriteLine ($"You have {lives} lives left. Try to guess again.");
                }
            }
        }
    }
}