using System;

namespace week8_practice
{
    enum PrimaryColors {
        red, blue, yellow
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Enums!");
            string combined = combineColors("red", "yellow");
            Console.WriteLine ("red + yellow = " +combined);

            string primaryCombined = combinePrimaryColors(PrimaryColors.red, PrimaryColors.yellow);
            Console.WriteLine ("red + yellow = " +primaryCombined);
        }
        public static string combinePrimaryColors (PrimaryColors color1, PrimaryColors color2) {
            if (color1 == PrimaryColors.red) {
                if (color2 == PrimaryColors.yellow){
                    return "orange";
                } else if (color2 == PrimaryColors.blue){
                    return "purple";
                }
            } return "unknown";
        }
        public static String combineColors (String color1, String color2){
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
