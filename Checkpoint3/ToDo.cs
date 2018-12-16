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
 UserSays userInput = new UserSays ();
 userInput.addToDoUser ();
 userInput.userUpdateTask ();
        }
    }
    /* This is the "brains" of the operation. It is going to control
    what happens and when it happens inside of a loop that will run based on the users input */
    class Controller {

    }
    class ConsoleUtils {

    }
    /* This is to help the code to be cleaner so that the user interaction methods are here.*/
    class UserSays {
        StoreDB theDao = new StoreDB ();
        //ToDo theToDo;
        //Menu (what the user can do: add, update, list, delete)
        public void optionsMenu () {
            Console.WriteLine ();
            Console.WriteLine ("Please choose from the following options: ");
            Console.WriteLine ("--------------------------------------------------------------------");
            Console.WriteLine (" 1- Add:            Adds a new ToDo to your list");
            Console.WriteLine (" 2- Update:         Updates an existing new ToDo, using ToDo's ID ");
            Console.WriteLine (" 3- Complete:       Completes an existing new ToDo, using ToDo's ID ");
            Console.WriteLine (" 4- Show New:       Shows only the ToDo's with a STATUS of NEW ");
            Console.WriteLine (" 5- Show Active:    Shows only the ToDo's with a STATUS of ACTIVE ");
            Console.WriteLine (" 6- Show Complete:  Shows only the ToDo's with a STATUS of COMPLETE ");
            Console.WriteLine (" 7- Show High:      Shows only the ToDo's with a PRIORITY of HIGH ");
            Console.WriteLine (" 8- Show Medium:    Shows only the ToDo's with a PRIORITY of MEDIUM ");
            Console.WriteLine (" 9- Show Low:       Shows only the ToDo's with a PRIORITY of LOW ");
            Console.WriteLine ("10- Show All:       Shows all ToDos ");
            Console.WriteLine ("--------------------------------------------------------------------");
        }
        // method to select the right method from user input based on menu choice
        public void userSelectOption () {

        }
        //User Add (To-Do object)
        public void addToDoUser () {
            Console.Write ("Add a task ToDo: ");
            string task = Console.ReadLine ();
            _Priority priority = _Priority.low;
            _Status status = _Status.@new;
            DateTime createdDate = DateTime.Now;
            theDao.addNew (task, priority, status, createdDate);
        }

        //User Update (any part of To-Do)
        //update TASK
        public void userUpdateTask () {
            Console.Write ("Would you like to update a task? Yes or No: ");
            string userUpdateYn = Console.ReadLine ().ToLower ().Trim ();
            if (userUpdateYn == "no" || userUpdateYn == "n") {
                return;
            } else if (userUpdateYn == "yes" || userUpdateYn == "y") {
                Console.Write ("Enter a ToDo ID:");
                string findId = Console.ReadLine ().ToString ().ToLower ().Trim ();
                theDao.findById (findId);
                ToDo found = theDao.context.toDos.Find (Convert.ToInt32 (findId));
                string founded = found.ToString ();
                Console.Write ($"Do you want to update:\n{found}\nEnter Yes or No:");
                string userWishUpdate = Console.ReadLine ().ToLower ().Trim ();
                if (userWishUpdate == "no" || userWishUpdate == "n") {
                    return;
                } else if (userWishUpdate == "yes" || userWishUpdate == "y") {
                    Console.Write ("Enter updated task: ");
                    string updatedTask = Console.ReadLine ();
                    theDao.updateTask (findId, updatedTask);
                    ToDo updatedTask1 = theDao.context.toDos.Find (Convert.ToInt32 (findId));
                    Console.WriteLine ($"Task: {founded}\nUpdated to:\n{updatedTask1}");
                } else {
                    //throw new Exception ("The input did not match Yes or No.\nYou will be directed to the options menu.");
                    Console.WriteLine ("Test: You didn't use yes or no.");
                }

            } else {
                //throw new Exception ("The input did not match Yes or No.\nYou will be directed to the options menu.");
                Console.WriteLine ("Test: You didn't use yes or no.");
            }

        }
        //update priority
        public void userUpdatePriority () {
            Console.Write ("Would you like to update a priority? Yes or No: ");
            string userUpdateYn = Console.ReadLine ().ToLower ().Trim ();
            if (userUpdateYn == "no" || userUpdateYn == "n") {
                return;
            } else if (userUpdateYn == "yes" || userUpdateYn == "y") {
                Console.Write ("Enter a ToDo ID:");
                string findId = Console.ReadLine ().ToString ().ToLower ().Trim ();
                theDao.findById (findId);
                ToDo found = theDao.context.toDos.Find (Convert.ToInt32 (findId));
                string founded = found.ToString ();
                Console.Write ($"Do you want to update:\n{found}\nEnter Yes or No:");
                string userWishUpdate = Console.ReadLine ().ToLower ().Trim ();
                if (userWishUpdate == "no" || userWishUpdate == "n") {
                    return;
                } else if (userWishUpdate == "yes" || userWishUpdate == "y") {
                    Console.Write ("Enter updated priority, Options are: high, medium, low\nEnter Option:");
                    _Priority updatedPriority = (_Priority)Enum.Parse(typeof(_Priority), Console.ReadLine ());
                    theDao.updatePriority (findId, updatedPriority);
                    ToDo updatedPriority1 = theDao.context.toDos.Find (Convert.ToInt32 (findId));
                    Console.WriteLine ($"Task: {founded}\nUpdated to:\n{updatedPriority1}");
                } else {
                    //throw new Exception ("The input did not match Yes or No.\nYou will be directed to the options menu.");
                    Console.WriteLine ("Test: You didn't use yes or no.");
                }

            } else {
                //throw new Exception ("The input did not match Yes or No.\nYou will be directed to the options menu.");
                Console.WriteLine ("Test: You didn't use yes or no.");
            }
        }
        //update status
        public void userUpdateStatus () {
            Console.Write ("Would you like to update a status? Yes or No: ");
            string userUpdateYn = Console.ReadLine ().ToLower ().Trim ();
            if (userUpdateYn == "no" || userUpdateYn == "n") {
                return;
            } else if (userUpdateYn == "yes" || userUpdateYn == "y") {
                Console.Write ("Enter a ToDo ID:");
                string findId = Console.ReadLine ().ToString ().ToLower ().Trim ();
                theDao.findById (findId);
                ToDo found = theDao.context.toDos.Find (Convert.ToInt32 (findId));
                string founded = found.ToString ();
                Console.Write ($"Do you want to update:\n{found}\nEnter Yes or No:");
                string userWishUpdate = Console.ReadLine ().ToLower ().Trim ();
                if (userWishUpdate == "no" || userWishUpdate == "n") {
                    return;
                } else if (userWishUpdate == "yes" || userWishUpdate == "y") {
                    Console.Write ("Enter updated priority, Options are: high, medium, low\nEnter Option:");
                    _Status updatedStatus = (_Status)Enum.Parse(typeof(_Status), Console.ReadLine ());
                    theDao.updateStatus (findId, updatedStatus);
                    ToDo updatedStatus1 = theDao.context.toDos.Find (Convert.ToInt32 (findId));
                    Console.WriteLine ($"Task: {founded}\nUpdated to:\n{updatedStatus1}");
                } else {
                    //throw new Exception ("The input did not match Yes or No.\nYou will be directed to the options menu.");
                    Console.WriteLine ("Test: You didn't use yes or no.");
                }

            } else {
                //throw new Exception ("The input did not match Yes or No.\nYou will be directed to the options menu.");
                Console.WriteLine ("Test: You didn't use yes or no.");
            }
        }

        //User List (Lists All)

        //User Query

        //User Delete (remove)

    }
    /* This is the data access object that will store and retrieve data from the data warehouse
        memory or otherwise
        also could be interface
    */
    class StoreDB {
        public Context context;
        //public ToDo createToDo;
        public StoreDB () {
            context = new Context ();
            context.Database.EnsureCreated ();
        }
        //Add a ToDo object set ID
        public void addNew (string task, _Priority priority, _Status status, DateTime createdDate) {
            context.toDos.Add (new ToDo (task, priority, status, createdDate));
            context.SaveChanges ();
        }
        public List<ToDo> addList () {
            List<ToDo> addList = new List<ToDo> ();
            foreach (ToDo something in context.toDos) {
                addList.Add (something);
            }
            return addList;
        }

        //Update a ToDo object by getting one first
        public ToDo findById (string findId) {
            foreach (ToDo _id in context.toDos) {
                if (_id.id.ToString () == findId) {
                    return _id;
                }
            }
            return null;
        }

        //update a task on a single Todo
        public void updateTask (string findId, string updatedTask) {
            string find = findId;
            ToDo _updateTask = findById (find);
            _updateTask.task = updatedTask;
            context.SaveChanges ();
            //update List object from addList

        }
        //update a priority on a single Todo
        public void updatePriority (string findId, _Priority updatedPriority) {
            string find = findId;
            ToDo _updatePriority = findById (find);
            _updatePriority.priority = updatedPriority;
            context.SaveChanges ();
            //update List object from addList
        }
        //update a status on a single Todo
        public void updateStatus (string findId, _Status updatedStatus) {
            string find = findId;
            ToDo _updateStatus = findById (find);
            _updateStatus.status = updatedStatus;
            context.SaveChanges ();
            //update List object from addList
        }
        //List ToDo objects

        //Remove a ToDo objects

        //

    }
    /* POCO - creates the ToDo object based on needs.
       ie- Task, ID, status, created date, completed date, deleted date
       These could act as the the model for the database.
     */
    public class ToDo {
        /* COOKIE CUTTER - This is the model for the To-Do item. */
        //ID
        public int id { get; set; }
        //Task
        public string task { get; set; }
        //Priority
        public _Priority priority { get; set; }
        //Status
        public _Status status { get; set; }
        //Created Date
        public DateTime createdDate { get; set; }
        //Closed Date
        //public DateTime closedDate;
        //Deleted Date
        //public DateTime deletedDate;
        // ToDo Constructor
        public ToDo (int id, string task, _Priority priority, _Status status, DateTime createdDate) {
            this.id = id;
            this.task = task;
            this.priority = priority;
            this.status = status;
            this.createdDate = createdDate;
            //test instantiation
            //Console.WriteLine ("I can be made.");
            //Console.WriteLine ($"Test:\n{id}\n{priority}\n{status}\n{task}\n{createdDate}");
        }
        public ToDo (string task, _Priority priority, _Status status, DateTime createdDate) {
            this.task = task;
            this.priority = priority;
            this.status = status;
            this.createdDate = createdDate;
        }
        //
        public override string ToString () {
            return
            id + "|| " + task + " || Priority: " + priority + " || Status: " + status + " || Created on: " + createdDate;
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