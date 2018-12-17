using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp {
    // enum for priority
    public enum _Priority { high, medium, low };
    // enum for status
    public enum _Status { @new, active, complete };
    class Program {
        /* WELCOMES USER and Instantiates a Controller that then does EVERYTHING */
        public static void Main (string[] args) {
            //WELCOME:
            Console.Clear();
            Console.WriteLine ("Yet another ToDo application... \nBy: Rachael Thompson");
            //create controller instance- run program
            bool run = true;
            while (run) {
                //try catch for exception in controller -- this mitigates impact from exception
                try {
                    Controller runProgram = new Controller ();
                } catch (Exception e) {
                    Console.WriteLine (" ");
                    Console.WriteLine (e.Message);
                    Console.Write("To return to the main screen, tap Enter:");
                    Console.ReadLine();
                    continue;
                } finally {
                    Console.Clear();
                }
                break;
            }
            //keep for debug- comment out later- tests
            //Console.WriteLine ("Hello World!");
            //test for instantiation of ToDo
            //ToDo one = new ToDo (1,_Priority.low, _Status.@new, "This is a task.",DateTime.Now);
                        // UserSays userInput = new UserSays ();
                        // userInput.optionsMenu ();
                        // userInput.userSelectOption ();
                        // userInput.addToDoUser ();
                        // userInput.userUpdateTask ();
                        // userInput.userUpdatePriority();
                        // userInput.userUpdateStatus();
                        // userInput.userDeleteToDo();
                        // userInput.userShowAll();
        }
    }
}