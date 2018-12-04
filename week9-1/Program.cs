using System;
using System.IO;
// file sharing / using files
namespace week9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            String file = @"test.txt";
            String [] lines = File.ReadAllLines(file);

            int lineNo = 0;
            foreach (string line in lines) {
                lineNo +=1;
                Console.WriteLine (lineNo +"- " +line);
            }
        }
    }
}
