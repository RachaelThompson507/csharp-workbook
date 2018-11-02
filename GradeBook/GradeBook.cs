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
        /*
        The return calculations method takes in the dictionary to be computed.
        */
            returnCalc();
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
            String studentName = " ";
            string studentGrades = " ";
            String studentInputYN = " ";
            Dictionary<String, String> gradeBook = new Dictionary<String, String> ();

            while (true) {
                //if the user does not enter a Y || N they will be directed back here to try again
                Beginning : Console.WriteLine ("Select Y to enter data, N to return calculations.");
                studentInputYN = Console.ReadLine ().ToUpper ();
                // if user is entering data do --- else if break ---else goto top
                if (studentInputYN == "Y") {
                    Console.WriteLine ("Enter students name in format 'last name , first name'.");
                    studentName = (Console.ReadLine ().ToUpper ());

                    Console.WriteLine ($"Enter grades for {studentName}.\nEach grade must be seperated by a coma.\nExample: (88,95)"); //interpolation is really cool!
                    studentGrades = Console.ReadLine ();

                    //enter string and gradestring into Gradebook
                    gradeBook.Add (studentName, studentGrades);

                    //else break loop
                } else if (studentInputYN == "N") {
                    break;

                    //else try again
                } else {
                    Console.WriteLine ("You did not make a choice of 'Y' or 'N', try again");
                    goto Beginning;
                }
            }
            Console.WriteLine ("_________________________________________________________");
            foreach (KeyValuePair <String, String> student in gradeBook) {
                Console.WriteLine ($" Students: {student.Key} | Grades: {student.Value} ");
                }
            Console.WriteLine ("_________________________________________________________");
        }
        public static int returnCalc (Dictionary gradeBook) {
            foreach (KeyValuePair <String, String> student in gradeBook){

            }
            //min grade
            //max grade
            //avg all
            //foreach loop for each calc
        }
    }
}