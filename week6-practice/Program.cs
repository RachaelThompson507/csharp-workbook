using System;
using System.Collections;
using System.Collections.Generic;

namespace week6_practice {
    class Program {
        //List that keeps track of cars and color
        static void Main (string[] args) {
            List<string> carsWithColor = new List<string> ();
            inventoryOfCars (carsWithColor);
            Console.WriteLine("-------------------------------------");
            foreach (string car in carsWithColor) {
                Console.WriteLine (" Inventory: {0} ", car);
                Console.WriteLine(" ");

            }

            Console.WriteLine(" ");
            Console.WriteLine("Has your inventory changed?");

        }
        public static List<string> inventoryOfCars (List<string> carsWithColor) {
            //List <string> carsWithColor = new List<string>();
            while (true) {
                enterDataQuestion : Console.WriteLine ("Would you like to enter a car to inventory? Y or N");
                string enterData = Console.ReadLine ().ToUpper ().Trim ();
                if (enterData == "Y") {
                    Console.WriteLine ("Enter a Color and Make of Car with a coma between, ie: Blue, Mazda:");
                    string carInventory = Console.ReadLine ().ToUpper ().Trim ();
                    carsWithColor.Add (carInventory);
                } else if (enterData == "N") {
                    break;
                } else {
                    Console.WriteLine ("You did not make a valid choice. Choose Y or N");
                    goto enterDataQuestion;
                }
            }
            return carsWithColor;
        }
        public static List<string> carSold (List<string> carsWithColor) {
            
        }
    }
}