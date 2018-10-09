using System;

namespace week2_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World!");
            //to upper will not show bc name didnt have a new var
            String name = "John";
            name.ToUpper();
            Console.WriteLine(name);
            //substring must be within the ints below and returns chars starting at {1}end 3 chars
            string name1 = name.Substring(1,3);
            Console.WriteLine(name1);
            //string.format example
            String template = "Hi {0}, my name is {1}.";
            String myName = "John";
            String yourName= "Bob";
            String sentence = String.Format(template, yourname, myName);
        }
    }
}
