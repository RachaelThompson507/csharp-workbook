using System;

namespace Inventory {
    class Program {
        // this is the main entry point and driver for this program
        static void Main (string[] args) {
            // initialize an empty list to hold the inventory
            List<Vehicle> inventory = new List<Vehicle> ();

            // this varaible tracks if the program should continue asking the user for input
            // or exit
            bool done = false;

            // while we are not done
            while (!done) {
                // ask the user for what they want to do
                String option = getUserOption ();

                // if they want to list the inventory
                // call the method to list it
                if (option == "list") {
                    printInventory (inventory);
                }
                // if they want to add an item to the inventory,
                // call the method to get the item from the user
                else if (option == "add") {
                    Vehicle newItem = getNewItem ();
                    inventory.Add (newItem);
                }
                // if they want to delete an item,
                // call a method to get the index of the item they want to delete
                else if (option == "delete") {
                    int idx = getDeletePosition ();
                    if (idx >= 0 && idx < inventory.Count) {
                        inventory.RemoveAt (idx);
                    } else {
                        Console.WriteLine ("Bad position");
                    }
                }
                // if they want to quit,
                // set the done flag to false, so the main loop exits
                else if (option == "quit") {
                    done = true;
                }

                // print an empty line just to break up the input
                // Console.clear would also work here
                Console.WriteLine ();
            }

        }

        // this method ask the user for a position they want to delete.
        // and returns it. if thy enter an non integer value, we return -1
        public static int getDeletePosition () {
            // ask the user for a position.
            Console.Write ("Choose an item to delete by entering its number: ");
            String input = Console.ReadLine ();
            try {
                // try to convert their input to an int
                // we subtract 1 from their input because the index in the list starts at 0
                // but we displayed the list with numbers starting at 1.
                return Convert.ToInt32 (input) - 1;
            } catch {
                // reutrn -1 if we could not convert their input to an int
                return -1;
            }

        }

        // this method ask the user for the item they want to add to the inventory
        // and return their input
        public static Vehicle getNewItem () {
            // ask for an item, and return the input
            Console.Write ("Enter a color: ");
            string Color = Console.ReadLine ();

            Console.Write ("Enter a make: ");
            string Make = Console.ReadLine ();

            Console.Write ("Enter a model: ");
            string Model = Console.ReadLine ();

            Console.Write ("Is this a hatchback? (y/n) ");
            String isHatchBack = (Console.ReadLine ();
            Vehicle newOne = new Car

        }

        // ask the user for a valid  input and reutrn it
        // we do not valid that option
        public static String getUserOption () {
            Console.Write ("Choose a command (list, add, delete) ");
            return Console.ReadLine ();
        }

        // print the inventory out to the console.
        public static void printInventory (List<Vehicle> inventory) {

            // if the inventory is empty, we print a message letting them know that
            // and exit the function
            if (inventory.Count == 0) {
                Console.WriteLine ("You dont have any inventory");
                return;
            }

            // we start at position 1, so the inventory has nice numbers
            // we should remeber that the user sees the numbers starting as 1,
            // so when asking for item to delete, we need to automatically
            // handle that the index into the list starts at 0.
            int index = 1;
            // loop through the inventory and print it to the console
            foreach (Vehicle item in inventory) {
                Console.WriteLine ("{0} - {1}", index, item);
                index++;
            }
        }
        public abstract class Vehicle {
            String Color;
            String Make;
            String Model;
            int numWheels;
            public Vehicle (string Color, string Make, string Model, int numWheels) {
                this.Color = Color;
                this.Make = Make;
                this.String = Model;
                this.numWheels = numWheels;
            }
            override
            public String ToString() {
                String formatted = String.Format("{0}, {1}, {2}", Color, Make, Model);
                return formatted;
            }
        }
        
        public class Car:Vehicle {
            bool isHatchBack;
            public Car (String Color, String Make, String Model, bool isHatchBack):base(Color, Make, Model, 4)
            {
                this.isHatchBack = isHatchBack;

            }
        }
    }
}