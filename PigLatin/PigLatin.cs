﻿using System;
using System.Threading;
namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            //Welcome user to application
            Console.WriteLine("Converting Words to Pig Latin");
            Thread.Sleep(2000);

            //User enters a word
            Console.WriteLine("Please enter a Word: ");

            //enter a string var for translation
            String word = (Console.ReadLine());
            //convert word to lowercase
            word = word.ToLower();
            //TranslateWord method is called and passed the word to translate.
            String translatedWord = TranslateWord(word);

            //Translated word is displayed to the user.
            //?-how to pass the translated word back to the user
            Console.WriteLine(translatedWord);

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

            /*Logic:
            If StartsWith Y - Y/N
                T- +yay to end of word
            Else if starts w/ Check vowels w/Y
                T- +yay to end of word
            ELSE F- check for first vowel (including Y) and
                move everything before 1st vowel to the end of the word
                then +ay
             */
            // return word; (will need to be added to each if)
        public static string TranslateWord(string word)
        {
            //Declaring Variables
             string beginY = "y";
             string addYay = "yay";
             string addAy = "ay";
             
            if (word.StartsWith(beginY))
            {
                word = string.Concat(word,addYay);
                return word;
            } else if ()
            {
                word = string.Concat(word,addYay);
                return word;
            }
            // else ()
            // {

            // }
            return word;
        }
    }
}
