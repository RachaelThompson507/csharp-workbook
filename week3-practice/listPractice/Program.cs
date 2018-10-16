using System;
using System.Collections.Generic;

namespace listPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<String> names = new List<String>();
            names.Add("John");
            names.Add("Mike");
            names.Add("Mark");

            Console.WriteLine(" The list has {0} elements ", names.Count);
            Console.WriteLine(" The first name is {0} ", names[0]);
        }
    }
}
