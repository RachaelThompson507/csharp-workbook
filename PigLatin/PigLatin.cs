    using System;
    using System.Threading;
    using System.Linq;
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
                String word = (Console.ReadLine().ToLower());

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
            public static string TranslateWord(string word)
            {
                //Declaring Variables
                string addYay = "yay";
                string addAy = "ay";
                string vowel = "aeiouy";
                string firstChar = word[0].ToString();

                if (firstChar == "y")
                {
                    word = string.Concat(word,addYay);
                    return word;

                } else if (vowel.Contains(firstChar))
                {
                    word = string.Concat(word,addYay);
                    return word;

                }else if (vowel.Contains(word))
                {
                    for (int i=0; i<word.Length; i++)
                   {

                    if (vowel.Contains(word[i]))
                    {
                        string firstVowel = word[i].ToString();
                        string firstHalf = word.Split(word[i])[0];
                        string lastHalf = word.Split(word[i])[1];
                        word = string.Concat(firstVowel, lastHalf,firstHalf, addAy);
                        return word;
                        break;
                    }
                   }

                }else
                {
                    return word = string.Concat(word, addAy);
                }
            }
        }
    }
