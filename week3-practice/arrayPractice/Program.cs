using System;

namespace arrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            String[] names = new String [4];
            names[0] = "James";
            names[1] = "Mike";
            names[2] = "Adam";
            names[3] = "Jane";

            String pets = { "Rocky", "Walter", "Tibs", "Bailey"};

            String [] cities;
            cities = new String[]{"Austin", "Dallas", "Houston"};

            Console.WriteLine("Names {0}, {1}, {2}, {3}.", names);

        }
    }
}
