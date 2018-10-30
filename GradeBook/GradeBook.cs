using System;
using System.Collections;
using System.Collections.Generic;

namespace GradeBook {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Grade Book an Application by GradePro");
        /*
        The data entry method takes in the data to be analyzed.
        */
            dataEntry ();
        }
        /*
        Contract:
        1. User input here.
        2. Loop through adding a name and grades.
        3. Stop when user is ready.
        4. Can names and grades be put into a dictionary for calling pairs of data?
         */
        public static void dataEntry () {
            // I started using Stacks- which worked but I could not get to work with a dictionary.
            // I cannot get the lists to work either-- any ideas?
            String studentNames = (" ");
            List <int> studentGrades = new List <int> {} ;
            //Dictionary <List<string>, List<string>> gradeBook = new Dictionary<List<string>, List<string>>();

            while (true) {
                //if the user does not enter a Y || N they will be directed back here to try again
                Beginning : Console.WriteLine ("Select Y to enter data, N to return calculations.");
                string inputYN = Console.ReadLine ().ToUpper ();
                // if user is entering data do --- else if break ---else goto top
                if (inputYN == "Y") {
                    Console.WriteLine ("Enter students name in format 'last name , first name'.");
                    studentNames = (Console.ReadLine ().ToUpper());

                    Console.WriteLine ($"Enter grades for {studentNames}\nEach grade must be a number.\nYou may enter as many grades as you would like.");
                    Console.WriteLine ($"To Exit entering grades for {studentNames}, type done.");
                    //to loop and add grades to a list - exit when done;
                
                } else if (inputYN == "N") {
                    break;

                } else {
                    Console.WriteLine ("You did not make a choice of 'Y' or 'N', try again");
                    goto Beginning;
                }
                    //I think I should test how the lists are taking in data with a foreach statement???
                    //foreach ()
                    //tried entering into dictionary here - didn't work threw exception ALSO
                    //gradeBook.Add (studentNames, studentGrades);
            }
        }
        //public static minMaxAvg(studentGrades) {
            
        //}
    }
}