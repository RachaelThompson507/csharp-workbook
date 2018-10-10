using System;
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
            String word = Convert.ToString(Console.ReadLine());
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
