using System;
using System.Threading; 

namespace textGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //game start
            int stick = 0;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to the cavern of secrets!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(3000);
            //do you take stick
            Console.WriteLine("You enter a dark cavern out of curiosity. It is dark and you can only make out a small stick on the floor.");
            Console.WriteLine("Do you take it [Y/N]");
            String ch1 = Console.ReadLine();
            //if take stick statement
            if(ch1 == "y" || ch1 == "Y" || ch1 == "Yes" || ch1 == "yes") {
                Console.WriteLine("You have taken the stick!");
                Thread.Sleep(2000);
                stick = 1;
            }else {
                Console.WriteLine("You did not take the stick.");
                stick = 0;
            }
            //approach spider
            Console.WriteLine("As you proceed further into the cave, you see a small glowing object");
            Console.WriteLine("Do you approach the object? [Y/N]");
            String ch2 = Console.ReadLine();
             if(ch2 == "y" || ch2 == "Y" || ch2 == "Yes" || ch2 == "yes") {
                Console.WriteLine("You approach the object...");
                Thread.Sleep(2000);
                Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
                Thread.Sleep(1000);
                Console.WriteLine("The eye belongs to a giant spider!");
                Console.WriteLine("Do you try to fight it? [Y/N]");
            String ch3 = Console.ReadLine();
            }else {
                    // Console.WriteLine("You did not take the stick!");
                    // Stick = 0;
            }
        }
    }
}
