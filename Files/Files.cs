using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Files {
    enum Alphabet {
        a,
        b,
        c,
        d,
        e,
        f,
        g,
        h,
        i,
        j,
        k,
        l,
        m,
        n,
        o,
        p,
        q,
        r,
        s,
        t,
        u,
        v,
        w,
        x,
        y,
        z
    }
    class Program {
        static void Main (string[] args) {
            Console.WriteLine (" ~~~ ---> Hangman <--- ~~~ ");

            //debug || test
            //Console.WriteLine (Files.generateRandom());
            //Console.WriteLine (GameLogic.DisplayWord ());
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
        public char guess { get; set; }
        public string wordGuessing { get; set; }
        //run method this method to generate random word from list and assign a value to object word;
        public static string DisplayWord () {
            //generate random word from list
            string wordToGuess = Files.generateRandom ();
            //This console.writeline is for debugging/validating the function works as intended.
            Console.WriteLine (wordToGuess);
            //create display to user
            StringBuilder displayWord = new StringBuilder (wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++) {
                displayWord.Append ("_ ");
            }

            string display = displayWord.ToString ();
            return display;
        }
        //overloaded method for display word
        public static string DisplayGuesses (char guess) {
            //create display to user after a guess
            StringBuilder displayWord = new StringBuilder (wordGuessing.Length);
            for (int i = 0; i < wordGuessing.Length; i++) {
                displayWord.Append ('_');
            }
            string newDisplay = displayWord.ToString ();
            return newDisplay;
        }
        public static void GuessGame (string wordToGuess) {
            wordGuessing = wordToGuess.ToLower ();
            List<char> correctLetter = new List<char> ();
            List<char> incorrectLetter = new List<char> ();
            // number of lives based on incorrect letters
            int lives = 5;
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

                            }
                        }
                    }
                }
            }
        }

    }
    class Game {

    }
}