using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook {
    class Program {
        static void Main (string[] args) {
            //declare variables
            String studentName = " ";
            String studentGrades = " ";
            String studentInputYN = " ";
            Dictionary<String, String> gradeBook = new Dictionary<String, String> ();

            //intro gradebook
            Console.WriteLine ("Grade Book an Application by GradePro");
            //while conditionals are true the app continues to get data
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
            foreach (KeyValuePair<String, String> student in gradeBook) {
                Console.WriteLine ($" Students: {student.Key} | Grades: {student.Value} ");
            }
            Console.WriteLine ("_________________________________________________________");

            maxGrade (gradeBook);
        }

        public static String maxGrade (Dictionary<String, String> gradeBook) {
            Dictionary <String, int> MaxGradePerStudent = new Dictionary <String, int> ();
            String maxDisplay = " ";
            //for each student in gradeBook do the following max grade on the Value String (studentGrades)
            foreach (KeyValuePair<String, String> student in gradeBook) {
                string [] splitMax = student.Value.Split (',');
                int max1 = Convert.ToInt32 (splitMax[0]);
                foreach (var maxCheck in splitMax) {
                    int splitMaxGrade = Convert.ToInt32 (maxCheck);
                    if (splitMaxGrade > max1) {
                        max1 = splitMaxGrade;
                    }
                }
                MaxGradePerStudent.Add(student.Key, max1);
            }
            foreach (KeyValuePair <String, int> studentMax in MaxGradePerStudent){
                maxDisplay = String.Format($"Student: {studentMax.Key}, Max Grade: {studentMax.Value}");
            }
            return maxDisplay;
        }
    }
}