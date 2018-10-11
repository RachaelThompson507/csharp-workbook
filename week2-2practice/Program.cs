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
        }
    }
}
