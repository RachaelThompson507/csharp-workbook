using System;

namespace ToDoApp
{
    //enums for priority

    //enums for status

    class Program
    {
        /* WELCOMES USER and Instantiates a Controller that then does EVERYTHING */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    /* This is the "brains" of the operation. It is going to control
    what happens and when it happens inside of a loop that will run based on the users input */
    class Controller
    {
        

    }
    /* This is to help the code to be cleaner so that the user interaction methods are here.*/
    class UserSays
    {
        //Menu (what the user can do: add, update, list, delete)

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
    class Store
    {
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
    class ToDo
    {
        //ID

        //Priority

        //Status

        //Task

        //Created Date

        //Due Date

        //Closed Date

        //Deleted Date

    }

}
