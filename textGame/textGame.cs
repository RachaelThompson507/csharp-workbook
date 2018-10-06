using System;
using System.Threading; 

namespace textGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int Stick = 0;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to the cavern of secrets!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(3000);
            Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("Do you take it [Y/N]");
            String ch1 = Console.ReadLine();

            if(ch1 == "y" || ch1 == "Y" || ch1 == "Yes" || ch1 == "yes") {
                Console.WriteLine("You have taken the stick!");
                Thread.Sleep(2000);
                Stick = 1;
            }else {
                Console.WriteLine("You did not take the stick!");
                Stick = 0;
            }
        }
    }
}
