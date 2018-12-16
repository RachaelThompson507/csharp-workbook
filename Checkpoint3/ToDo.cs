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
            Console.WriteLine ("Yet another ToDo application... \nBy: Rachael Thompson");

            //keep for debug- comment out later
            //Console.WriteLine ("Hello World!");
            //test for instantiation of ToDo
            //ToDo one = new ToDo (1,_Priority.low, _Status.@new, "This is a task.",DateTime.Now);
            //UserSays.optionsMenu ();
                        //UserSays userInput = new UserSays ();
                        //userInput.addToDoUser ();
                        // userInput.userUpdateTask ();
                        // userInput.userUpdatePriority();
                        // userInput.userUpdateStatus();
        }
    }
    /* This is the "brains" of the operation. It is going to control
    what happens and when it happens inside of a loop that will run based on the users input */
    class Controller {

    }
    class ConsoleUtils {

    }

    public class Context : DbContext {
        public DbSet<ToDo> toDos { get; set; }

        override
        protected void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite ("Filename=./ToDo.db");
        }
    }
}