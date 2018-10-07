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
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("!!!!!!!!Converting!!!!!!!!");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep(1000);
            Console.WriteLine("{0} yards * {1} inches = {2} inches", yards, inches, yards*inches);
            Thread.Sleep(2000);
        }
    }
}
