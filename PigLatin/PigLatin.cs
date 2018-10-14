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
                // run tests and print out if tests passed or not
                if(tests()){
                    Console.WriteLine("Tests passed.");
                } else {
                    Console.WriteLine("Tests failed.");
                }
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
                //check for word begin with Y
                if (firstChar == "y")
                {
                    word = string.Concat(word,addYay);
                    return word;
                //check for word with vowel first character
                } else if (vowel.Contains(firstChar))
                {
                    word = string.Concat(word,addYay);
                    return word;
                //check for vowel in word and rearrange word
                } else
                {
                    for (int i=0; i<word.Length; i++)
                    {
                        if (vowel.Contains(word[i]))
                        {
                            string firstVowel = word[i].ToString();
                            string firstHalf = word.Split(word[i])[0];
                            string lastHalf = word.Split(word[i])[1];
                            word = string.Concat(firstVowel, lastHalf, firstHalf, addAy);
                            return word;
                            break;
                        }
                   }
                }
                //other wise return a word that adds AY
                return word = string.Concat(word, addAy);
            }
             /**
            This method tests some examples against the 5 following rules,
            and returns true if all tests pass, otherwise returns false.

            rule 1: if it starts with a vowel add "yay" to the end
            rule 2: move all letter before the first vowel to the end, then add "ay" to the end
            rule 3: if it starts with a "y", treat the "y" as a consonant
            rule 4: if it does not start with a "y", treat the "y" as a vowel
            rule 5: if there are no vowels, add "ay" to the end (this is the same as rule 2) 
            */
            public static bool tests()
            {
            return
                TranslateWord("elephant") == "elephantyay" &&
                TranslateWord("fox") == "oxfay" &&
                TranslateWord("choice") == "oicechay" &&
                TranslateWord("dye") == "yeday" &&
                TranslateWord("bystander") == "ystanderbay" &&
                TranslateWord("yellow") == "ellowyay" &&
                TranslateWord("tsktsk") == "tsktskay";
            }
        }
    }
