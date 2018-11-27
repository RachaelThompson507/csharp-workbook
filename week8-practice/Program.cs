using System;

namespace week8_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Enums!");
            string junk = combineColors("hotPink", "tangerine");
        }
        static String combineColors (String color1, String color2){
            if (color1 == "red") {
                if (color2 == "yellow"){
                    return "orange";
                } else if (color2 == "blue"){
                    return "purple";
                }
            } return "unknown";
        }
    }
}
