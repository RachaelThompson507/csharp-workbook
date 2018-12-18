using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp {
    /* This is the "brains" of the operation. It is going to control
    what happens and when it happens inside of a loop that will run based on the users input */
    class Controller {
        public static bool running = true;
        public Controller () {
            //create an instance of userSays
            UserSays userInput = new UserSays ();
            while (running) {
                try {
                    userInput.optionsMenu ();
                    userInput.userSelectOption ();
                    Console.Clear();
                } catch (Exception e) {
                    Console.WriteLine (e.Message);
                    Console.Write("To return to the main screen, tap Enter:");
                    Console.ReadLine();
                    continue;
                } finally {
                    throw new Exception ("The input did not match Yes or No.\nYou will be directed to the options menu.");
                }
            }
        }
    }
}