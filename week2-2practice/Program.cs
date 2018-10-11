using System;

namespace week2_2practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask user for a number
            //if # is an A, print out 'you made an A'
            //an A is 90 to 100
            Console.WriteLine("Please enter a number.");
            int grade = Convert.ToInt32(Console.ReadLine());

            if(grade >=90)
            {
                Console.WriteLine("You have an A!");
            } else if (grade >=80)
            {
                Console.WriteLine("You have a B.");
            }else if (grade >=70)
            {
                Console.WriteLine("You have a C.");
            } else
            {
                Console.WriteLine("You did not pass.");
            }
            Console.WriteLine("End Program");

            //bool logic example
            String name = null;
            if (name != null && name.Length > 6)
            {
                Console.WriteLine("your name is long");
            } else
            {
                Console.WriteLine("Your name is short or you don't have a name.");
            }
        }
    }
}
