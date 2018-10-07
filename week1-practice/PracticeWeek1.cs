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
            Console.WriteLine("What 2 numbers would you like to add?");
            Console.WriteLine("Please enter number 1");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter number 2");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The answer is...");
            Console.WriteLine("{0}+{1}={2}", a, b, a+b);
            Thread.Sleep(2000);
            //2- converting yard to inches

        }
    }
}
