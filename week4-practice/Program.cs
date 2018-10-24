using System;
using System.Collections.Generic;

namespace week4_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<string> names = new List<string> {"Bob", "Johnny", "Jack", "Mark", "Joy", "Rachael"};
            foreach(string name in names){
                Console.WriteLine(name);
            }
        }
    }
}
