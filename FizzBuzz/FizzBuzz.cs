using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            FizzBuzz:
            Count from the number 1
            Any number divisible by 3 = Fizz
            Any number divisible by 5 = Buzz
            Numbers that are divisible by both = FizzBuzz
             */
             Console.WriteLine("FizzBuzz");
             Console.WriteLine("Enter a number...");
             int numEntered = Convert.ToInt32(Console.ReadLine());
             //fizzBuzz(numEntered);
             //Console.WriteLine(fizzBuzz(numEntered));
             fizzBuzz(numEntered);

        }
        public static void fizzBuzz(int numEntered)
        {
            int i = 0;
            for (i=0; i<=numEntered; i++){
                bool fizz = i % 3 == 0;
                bool buzz = i % 5 == 0;
                if(fizz && buzz){
                   Console.WriteLine( "FizzBuzz" );
                } else if (fizz){
                    Console.WriteLine("Fizz");
                }else if (buzz){
                    Console.WriteLine( "Buzz");
                } else {
                    string i1 = i.ToString();
                    Console.WriteLine( i1);
                }
            } //return "Could not find the number";
        }
    }
}
