using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace ToDoApp {
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
                    Console.Write ("Enter updated priority, Options are: new, active, complete\nEnter Option:");
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
}