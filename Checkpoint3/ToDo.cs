using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ToDoApp {
        // enum for priority
        enum _Priority { high = 3, medium = 2, low = 1 };
        // enum for status
        enum _Status { @new, active, complete };
    class Program {
        /* WELCOMES USER and Instantiates a Controller that then does EVERYTHING */
         static void Main (string[] args) {
            //keep for debug- comment out later
            //Console.WriteLine ("Hello World!");
            //test for instantiation of ToDo
            //ToDo one = new ToDo (1,_Priority.low, _Status.@new, "This is a task.",DateTime.Now);
            //UserSays.optionsMenu ();
        }
    }
    /* This is the "brains" of the operation. It is going to control
    what happens and when it happens inside of a loop that will run based on the users input */
    class Controller {

    }
    /* This is to help the code to be cleaner so that the user interaction methods are here.*/
    class UserSays {
        //Menu (what the user can do: add, update, list, delete)
        public static void optionsMenu () {
            Console.WriteLine ();
            Console.WriteLine ("Please choose from the following options: ");
            Console.WriteLine ("--------------------------------------------------------------------");
            Console.WriteLine (" 1- Create:         Creates a new ToDo ");
            Console.WriteLine (" 2- Update:         Updates an existing new ToDo, using ToDo's ID ");
            Console.WriteLine (" 3- Delete:         Deletes an existing new ToDo, using ToDo's ID ");
            Console.WriteLine (" 4- Show New:       Shows only the ToDo's with a STATUS of NEW ");
            Console.WriteLine (" 5- Show Active:    Shows only the ToDo's with a STATUS of ACTIVE ");
            Console.WriteLine (" 6- Show Complete:  Shows only the ToDo's with a STATUS of COMPLETE ");
            Console.WriteLine (" 7- Show High:      Shows only the ToDo's with a PRIORITY of HIGH ");
            Console.WriteLine (" 8- Show Medium:    Shows only the ToDo's with a PRIORITY of MEDIUM ");
            Console.WriteLine (" 9- Show Low:       Shows only the ToDo's with a PRIORITY of LOW ");
            Console.WriteLine ("--------------------------------------------------------------------");
        }
        //User Add (To-Do object)

        //User Update (any part of To-Do)

        //User List (Lists All)

        //User Query

        //User Delete (remove)

    }
    /* This is the data access object that will store and retrieve data from the data warehouse
        memory or otherwise
        also could be interface
    */
    class StoreDB {
        //Add a ToDo object set ID

        //Update a ToDo object

        //List ToDo objects

        //Remove a ToDo objects

        //

    }
    /* POCO - creates the ToDo object based on needs.
       ie- Task, ID, status, created date, completed date, deleted date
       These could act as the the model for the database.
     */
    class ToDo {
        /* COOKIE CUTTER - This is the model for the To-Do item. */
        //ID
        public int id { get; set; }
        //Priority
        public _Priority priority = _Priority.low;
        //Status
        public _Status status = _Status.@new;
        //Task
        public string task { get; set; }
        //Created Date
        public DateTime createdDate = DateTime.Now;
        //Closed Date
        //public DateTime closedDate;
        //Deleted Date
        //public DateTime deletedDate;
        // ToDo Constructor
        public ToDo (int id, _Priority priority, _Status status, string task, DateTime createdDate) {
            this.id = id;
            this.priority= _Priority.low;
            this.status = _Status.@new;
            this.task = task;
            this.createdDate = createdDate;
            //test instantiation
            //Console.WriteLine ("I can be made.");
            //Console.WriteLine ($"Test:\n{id}\n{priority}\n{status}\n{task}\n{createdDate}");
        }
    }
}