using System;
using System.Linq;
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
        //for each student in gradeBook do the following calculations on the Value String (studentGrades)
            foreach (KeyValuePair <String, String> student in gradeBook){
                //calculate max grade
                if (student.Value == String){
                    var gradeSplit = student.Value.Split(',');
                    //assumption first number could be largest number
                    var max = Convert.ToInt32 (gradeSplit[0]);
                    //use for each again to check each number if it the greatest number
                    foreach (int grades in gradeSplit){
                        int grade = Convert.ToInt32 (grades);
                        if (grade > max) {
                            max = grade;
                        }
                    }
                    return String.Format(student.Key, max);
                } if (student.Value == String) {
                    var gradeSplitMin = student.Value.Split(',');
                    //assumption first number could be smallest number
                    var min = Convert.ToInt32 (gradeSplit[0]);
                    //use for each again to check each number if it the number that is the least
                    foreach (int gradesMin in gradeSplit){
                        int gradeMin = Convert.ToInt32 (gradesMin);
                        if (gradeMin < min) {
                            min = gradeMin;
                        }
                    }
                    return String.Format(student.Key, min);
                } if (student.Value == String) {
                    var gradeSplitAvg = student.Value.Split(',').Convert.ToInt32.ToArray();
                    foreach (int gradeAvg in gradeSplitAvg){
                        int gradeAvg = gradeSplitAvg.Average();
                    }
                    return String.Format(student.Key, gradeAvg);
                }
            }
        }
    }
}