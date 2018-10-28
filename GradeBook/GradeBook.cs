using System;
using System.Collections;
using System.Collections.Generic;

namespace GradeBook {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Grade Book an Application by GradePro");
            dataEntry ();
        }
        public static void dataEntry () {

            while (true) {
                Beginning : Console.WriteLine ("Select Y to enter data, N to return calculations.");
                string inputYN = Console.ReadLine ().ToUpper ();

                if (inputYN == "Y") {
                    Console.WriteLine ("Enter students name in format 'last name , first name'.");
                    Stack studentNames = new Stack ();
                    studentNames.Push (Console.ReadLine ());

                    Console.WriteLine ($"Enter grades for {studentNames.Peek()}. \n Each grade must be seperated by a coma. \n Example: (88,95)");
                    Stack studentGrades = new Stack ();
                    studentGrades.Push (Console.ReadLine ());
                } else if (inputYN == "N") {
                    break;
                } else {
                    Console.WriteLine ("You did not make a choice of 'Y' or 'N', try again");
                    goto Beginning;
                }
            }
        }
    }
}