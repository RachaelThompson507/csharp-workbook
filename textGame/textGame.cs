using System;
using System.Threading;

namespace textGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables
            int stick = 0;
            Random fdmg1 = new Random();
            Random edmg1 = new Random();
            int complete = 0;
            //game start
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
            if(ch2 == "y" || ch2 == "Y" || ch2 == "Yes" || ch2 == "yes")
            {
                Console.WriteLine("You approach the object...");
                Thread.Sleep(2000);
                Console.WriteLine("As you draw closer, you begin to make out the object as an eye!");
                Thread.Sleep(1000);
                Console.WriteLine("The eye belongs to a giant spider!");
                Console.WriteLine("Do you try to fight it? [Y/N]");
                String ch3 = Console.ReadLine();
                //fight spider with stick
                if(ch2 == "y" || ch2 == "Y" || ch2 == "Yes" || ch2 == "yes")
                { Console.WriteLine("You only have a stick to fight with!");
                  Console.WriteLine("You quickly jab the spider in it's eye and gain an advantage");
                  Thread.Sleep(2000);
                  Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                  Console.WriteLine("                  Fighting...                   ");
                  Console.WriteLine("   YOU MUST HIT ABOVE A 5 TO KILL THE SPIDER    ");
                  Console.WriteLine("IF THE SPIDER HITS HIGHER THAN YOU, YOU WILL DIE");
                  Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                  Thread.Sleep(2000);
                  Console.WriteLine("You hit a {0}", fdmg1.Next(3, 10));
                  Console.WriteLine("The spider hits a {0}", edmg1.Next(1, 5));
                  Thread.Sleep(2000);
                  int fdmgint = fdmg1.Next();
                  int edmgint = edmg1.Next();
                    if( edmgint > fdmgint )
                    {
                        Console.WriteLine("The spider has dealt more damage than you!");
                        complete = 0;
                    }else if( fdmgint < 5 )
                    {
                        Console.WriteLine("You didn't do enough damage to kill the spider, but you manage to escape");
                        complete = 1;
                    }else {
                        Console.WriteLine("You killed the spider!");
                        complete = 1;
                    }
                }
            }
        }
    }
}
