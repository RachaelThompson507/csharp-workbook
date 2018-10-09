using System;
using System.Threading;
namespace PigLatin
{
    class Program
    {
        public static void Main()
        {
            //Declare variable string
            String word = " ";
            //Welcome user to application
            Console.WriteLine("Converting Words to Pig Latin");
            Thread.Sleep(2000);
            //User enters a word
            Console.WriteLine("Please enter a Word: ");
            word = Console.ReadLine();
            //TranslateWord method is called and passed the word to translate.
            TranslateWord(word);
            //Translated word is displayed to the user.
            //?-how to pass the translated word back to the user
            Console.WriteLine(word);
            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static string TranslateWord(string word)
        {
            
            return word;
        }
    }
}
