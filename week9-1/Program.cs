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
            //read all the lines in the file
            String [] lines = File.ReadAllLines(file);

            //read lines are printed to the console
            int lineNo = 0;
            foreach (string line in lines) {
                lineNo +=1;
                Console.WriteLine (lineNo +"- " +line);
            }

            //write to the file
            String copyFile = @"test1.txt";
            File.AppendAllLines (copyFile, lines);
            //print the new one
            // int lineNo1 = 0;
            // String [] lines1 = File.ReadAllLines(copyFile);
            // foreach (string line1 in lines1) {
            //     lineNo1 +=1;
            //     Console.WriteLine (lineNo1 +"- " +lines1);
            // }
        }
    }
}
