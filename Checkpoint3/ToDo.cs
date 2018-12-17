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
            Console.WriteLine ("Yet another ToDo application... \nBy: Rachael Thompson");
            //create controller instance- run program
            bool run = true;
            while (run) {
                try {
                    Controller runProgram = new Controller ();
                } catch (Exception e) {
                    Console.WriteLine (" ");
                    Console.WriteLine (e.Message);
                    continue;
                } finally {
                    Console.WriteLine("Thank You for using ToDo App.");
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
    /* This is the "brains" of the operation. It is going to control
    what happens and when it happens inside of a loop that will run based on the users input */
    class Controller {
        public Controller () {
            //create an instance of userSays
            UserSays userInput = new UserSays ();
            bool running = true;
            while (running) {
                try {
                    userInput.optionsMenu();
                    userInput.userSelectOption();
                } catch (Exception e) {
                    Console.WriteLine (e.Message);
                    continue;
                } finally {
                    Console.Write ("Do you wish to continue using ToDo App? Yes or No: ");
                    string input = Console.ReadLine ().ToLower().Trim();
                    if (input == "no" || input == "n") {
                        running = false;
                    } else if (input == "yes" || input == "y") {
                        running = true;
                    } else {
                        running = true;
                        throw new Exception ("The input did not match Yes or No.\nYou will be directed to the options menu.");
                    }
                }
            }
        }

    }

    public class Context : DbContext {
        public DbSet<ToDo> toDos { get; set; }

        override
        protected void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite ("Filename=./ToDo.db");
        }
    }
}