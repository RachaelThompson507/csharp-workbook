using System;
using System.Threading;

namespace week1_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //hello world
            Console.WriteLine("Hello World!");
            Thread.Sleep(2000);
            // 1-add 2 numbers and display result
            Console.WriteLine("We are going to add 2 numbers together.");
            Thread.Sleep(1000);
            Console.WriteLine("What 2 numbers would you like to add?");
            Console.WriteLine("Please enter number 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The answer is...");
            Console.WriteLine("{0}+{1}={2}", num1, num2, num1+num2);
            Thread.Sleep(2000);
            //2- converting yard to inches
            Console.WriteLine("Let's convert yards to inches!");
            Thread.Sleep(1000);
            Console.WriteLine("How many yards did you measure?");
            Console.WriteLine("Please enter the number of yards:");
            double yards = Convert.ToDouble(Console.ReadLine());
            double inches = 36;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("!!!!!!!! Converting !!!!!!!!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(1000);
            Console.WriteLine("{0} yards * {1} inches = {2} inches", yards, inches, yards*inches);
            Thread.Sleep(2000);
            //3/4-boolean values
            Console.WriteLine("Are there people that attend ACA? -- True or False");
            Thread.Sleep(1000);
            bool people = true;
            bool f = false;
            if (people)
            {
                Console.WriteLine("There are people that attend ACA: {0}", people);
            }
            else
            {
                Console.WriteLine(f);
            }
            Thread.Sleep(2000);
            //5/6-make var num a decimal and multiply it by itself
            Console.WriteLine("Let's multiply decimals!");
            Thread.Sleep(1000);
            Console.WriteLine("Please enter a decimal value:");
            decimal num = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("!!!!!!!! Multiplying !!!!!!!!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(1000);
            Console.WriteLine("{0} decimal * {1} decimal = {2} decimal squared", num, num, num*num);
            Thread.Sleep(2000);
            //7/8- personal information q&a
            Console.WriteLine("I have some questions for you.");
            Console.WriteLine("Can you answer these, please?");
            Thread.Sleep(1000);
            Console.WriteLine("What is your first name?");
            string firstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("What is your last name?");
            string lastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("What is your age?");
            string age = Convert.ToString(Console.ReadLine());
            Console.WriteLine("What is your occupation?");
            string job = Convert.ToString(Console.ReadLine());
            Console.WriteLine("What is your favorite band?");
            string favBand = Convert.ToString(Console.ReadLine());
            Console.WriteLine("What is your favorite sports team?");
            string favSportTeam = Convert.ToString(Console.ReadLine());
            Thread.Sleep(1000);
            Console.WriteLine("Let me out this information together for you.");
            Thread.Sleep(2000);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("!!!!!!!! Computing !!!!!!!!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(2000);
            Console.WriteLine("My name is {0} {1} and I am {2} years old.", firstName, lastName, age);
            Console.WriteLine("My occupation is {0}.", job);
            Console.WriteLine("My favorite band is {0} and I enjoy watching the {1}.", favBand, favSportTeam);
            Thread.Sleep(2000);
            //Convert var num to int
            Console.WriteLine("We are going to divide integers.");
            Thread.Sleep(1000);
            Console.WriteLine("Please enter a valid integer.");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another valid integer.");
            num1 = Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(2000);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("!!!!!!!! Dividing !!!!!!!!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("{0} / {1} = {2} ", num, num1, num/num1);
            Thread.Sleep(2000);
        }
    }
}
