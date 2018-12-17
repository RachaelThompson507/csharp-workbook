using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace ToDoApp {
    enum _Options { Add = 1, UpdateTask = 2, UpdatePriority = 3, UpdateStatus = 4, DeleteToDo = 5, ShowAll = 6, Quit = 7};
    /* This is to help the code to be cleaner so that the user interaction methods are here.*/
    class UserSays {
        StoreDB theDao = new StoreDB ();
        List <ToDo> _listToDo = new List<ToDo> ();
        //ToDo theToDo;
        //Menu (what the user can do: add, update, list, delete)
        public void optionsMenu () {
            Console.Clear();
            Console.WriteLine ();
            Console.WriteLine ("Please choose from the following options: ");
            Console.WriteLine ("--------------------------------------------------------------------");
            Console.WriteLine (" 1- Add:                Adds a new ToDo to your list");
            Console.WriteLine (" 2- Update Task:        Updates an existing new ToDo, using ToDo's ID ");
            Console.WriteLine (" 3- Update Priority:    Updates an existing new ToDo, using ToDo's ID ");
            Console.WriteLine (" 4- Update Status:      Updates an existing new ToDo, using ToDo's ID ");
            Console.WriteLine (" 5- Delete:             Deletes an existing new ToDo, using ToDo's ID ");
            Console.WriteLine (" 6- Show All:           Shows all ToDos ");
            Console.WriteLine (" 7- Quit:               Exit Program Menu");
            Console.WriteLine ("--------------------------------------------------------------------");
        }
        // method to select the right method from user input based on menu choice
        public void userSelectOption () {
            Console.Write ("Please enter an option number: ");
            _Options userSelect = (_Options)Enum.Parse(typeof (_Options), Console.ReadLine());
            switch (userSelect){
                case _Options.Add:
                    addToDoUser ();
                    break;
                case _Options.UpdateTask:
                    userUpdateTask();
                    break;
                case _Options.UpdatePriority:
                    userUpdatePriority();
                    break;
                case _Options.UpdateStatus:
                    userUpdateStatus();
                    break;
                case _Options.DeleteToDo:
                    userDeleteToDo();
                    break;
                case _Options.ShowAll:
                    userShowAll();
                    break;
                case _Options.Quit:
                    Controller.running = false;
                    break;
                default:
                    throw new Exception ("That was not a valid choice. Please try again.");
            }
        }
        //User Add (To-Do object)
        public void addToDoUser () {
            Console.Clear();
            Console.Write ("Add a task ToDo: ");
            string task = Console.ReadLine ();
            _Priority priority = _Priority.low;
            _Status status = _Status.@new;
            DateTime createdDate = DateTime.Now;
            theDao.addNew (task, priority, status, createdDate);
            Console.Clear();
            theDao.listToDo();
        }

        //User Update (any part of To-Do)
        //update TASK
        public void userUpdateTask () {
            Console.Clear();
            Console.Write ("Would you like to update a task? Yes or No: ");
            string userUpdateYn = Console.ReadLine ().ToLower ().Trim ();
            if (userUpdateYn == "no" || userUpdateYn == "n") {
                return;
            } else if (userUpdateYn == "yes" || userUpdateYn == "y") {
                Console.Clear();
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
                    Console.Clear();
                    Console.Write ("Enter updated task: ");
                    string updatedTask = Console.ReadLine ();
                    theDao.updateTask (findId, updatedTask, _listToDo);
                    ToDo updatedTask1 = theDao.context.toDos.Find (Convert.ToInt32 (findId));
                    Console.WriteLine ($"Task: {founded}\nUpdated to:\n{updatedTask1}");
                } else {
                    throw new Exception ("The input did not match Yes or No.\nYou will be directed to the options menu.");
                    //Console.WriteLine ("Test: You didn't use yes or no.");
                }

            } else {
                throw new Exception ("The input did not match Yes or No.\nYou will be directed to the options menu.");
                //Console.WriteLine ("Test: You didn't use yes or no.");
            }

        }
        //update priority
        public void userUpdatePriority () {
            Console.Clear();
            Console.Write ("Would you like to update a priority? Yes or No: ");
            string userUpdateYn = Console.ReadLine ().ToLower ().Trim ();
            if (userUpdateYn == "no" || userUpdateYn == "n") {
                return;
            } else if (userUpdateYn == "yes" || userUpdateYn == "y") {
                Console.Clear();
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
                    Console.Clear();
                    Console.Write ("Enter updated priority, Options are: high, medium, low\nEnter Option:");
                    _Priority updatedPriority = (_Priority)Enum.Parse(typeof(_Priority), Console.ReadLine ());
                    theDao.updatePriority (findId, updatedPriority,_listToDo);
                    ToDo updatedPriority1 = theDao.context.toDos.Find (Convert.ToInt32 (findId));
                    Console.WriteLine ($"Task: {founded}\nUpdated to:\n{updatedPriority1}");
                } else {
                    throw new Exception ("The input did not match Yes or No.\nYou will be directed to the options menu.");
                    //Console.WriteLine ("Test: You didn't use yes or no.");
                }

            } else {
                throw new Exception ("The input did not match Yes or No.\nYou will be directed to the options menu.");
                //Console.WriteLine ("Test: You didn't use yes or no.");
            }
        }
        //update status
        public void userUpdateStatus () {
            Console.Clear();
            Console.Write ("Would you like to update a status? Yes or No: ");
            string userUpdateYn = Console.ReadLine ().ToLower ().Trim ();
            if (userUpdateYn == "no" || userUpdateYn == "n") {
                return;
            } else if (userUpdateYn == "yes" || userUpdateYn == "y") {
                Console.Clear();
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
                    Console.Clear();
                    Console.Write ("Enter updated priority, Options are: new, active, complete\nEnter Option:");
                    _Status updatedStatus = (_Status)Enum.Parse(typeof(_Status), Console.ReadLine ());
                    theDao.updateStatus (findId, updatedStatus, _listToDo);
                    ToDo updatedStatus1 = theDao.context.toDos.Find (Convert.ToInt32 (findId));
                    Console.WriteLine ($"Task: {founded}\nUpdated to:\n{updatedStatus1}");
                } else {
                    throw new Exception ("The input did not match Yes or No.\nYou will be directed to the options menu.");
                    //Console.WriteLine ("Test: You didn't use yes or no.");
                }

            } else {
                throw new Exception ("The input did not match Yes or No.\nYou will be directed to the options menu.");
                //Console.WriteLine ("Test: You didn't use yes or no.");
            }
        }
        //User Delete (remove)
        public void userDeleteToDo () {
            Console.Clear();
            Console.Write ("Would you like to delete a ToDo item? Yes or No: ");
            string userUpdateYn = Console.ReadLine ().ToLower ().Trim ();
            if (userUpdateYn == "no" || userUpdateYn == "n") {
                return;
            } else if (userUpdateYn == "yes" || userUpdateYn == "y") {
                Console.Clear();
                Console.Write ("Enter a ToDo ID:");
                string findId = Console.ReadLine ().ToString ().ToLower ().Trim ();
                theDao.findById (findId);
                ToDo found = theDao.context.toDos.Find (Convert.ToInt32 (findId));
                Console.Write ($"Do you want to DELETE:\n{found}\nEnter Yes or No:");
                string userWishUpdate = Console.ReadLine ().ToLower ().Trim ();
                if (userWishUpdate == "no" || userWishUpdate == "n") {
                    return;
                } else if (userWishUpdate == "yes" || userWishUpdate == "y") {
                    Console.Clear();
                    theDao.deleteToDo (findId, _listToDo);
                    Console.WriteLine ($"ToDo item [ {found} ] has been deleted.");
                } else {
                    throw new Exception ("The input did not match Yes or No.\nYou will be directed to the options menu.");
                    //Console.WriteLine ("Test: You didn't use yes or no.");
                }

            } else {
                throw new Exception ("The input did not match Yes or No.\nYou will be directed to the options menu.");
                //Console.WriteLine ("Test: You didn't use yes or no.");
            }
        }
        public void userShowAll () {
            List<ToDo> ShowAll = theDao.listToDo();
            Console.Clear();
            Console.Write ("Current ToDos:");
            Console.WriteLine();
            foreach (ToDo showing in ShowAll) {
                Console.WriteLine (showing);
            }
            Console.WriteLine();
        }
    }
}