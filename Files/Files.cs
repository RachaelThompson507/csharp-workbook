using System;
using System.IO;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  ---> Hangman <---  ");

            //debug || test
            //Console.WriteLine (Files.generateRandom());
        }
    }
    class Files
    {
        //path of the file to be used
        public string file {get; private set;}
        //generates a random word by reading the file since all words are on their own lines
        public static string generateRandom () {
            string file = @"WordList.txt";
            string [] lines = File.ReadAllLines(file);
            Random r = new Random ();
            int line = r.Next(0, lines.Length-1);
            string word = lines[line];
            return word;
        }
    }
    class GameLogic
    {
        

    }
    class Game
    {

    }
}
