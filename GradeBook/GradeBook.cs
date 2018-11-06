using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GradeBook {
    class Program {
        static void Main (string[] args) {
            //declare main variable
            Dictionary<String, String> gradeBook = new Dictionary<String, String> ();
            Dictionary<String, int> gradeBookMax = new Dictionary<String, int> ();
            Dictionary<String, int> gradeBookMin = new Dictionary<String, int> ();
            Dictionary<String, decimal> gradeBookAvg = new Dictionary<String, decimal> ();
            String studentInputYN = " "; //determines loop dataentry
            //intro gradebook
            Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine ("Grade Book an Application by Rachael Thompson");
            Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //this does the collecting of the data and interacting with user
            //try-catch for data entry errors
            try {
                dataEntry (gradeBook, studentInputYN);
            } catch (Exception) {
                if (studentInputYN != "Y" || studentInputYN != "N") {
                    Console.WriteLine ("Choice Invalid: Please make a choice of Y or N.");
                    dataEntry (gradeBook, studentInputYN);
                }
            } finally {
                Console.WriteLine("STUDENTS:");
                foreach (KeyValuePair<String, String> student in gradeBook) {
                    Console.WriteLine ($" Students: {student.Key} | Grades: {student.Value} ");
                }
                Console.WriteLine ($" _________________________________________________ ");
            }

            maxGrade (gradeBook, gradeBookMax);
            Console.WriteLine("MAX GRADES:");
            foreach (KeyValuePair<String, int> student1 in gradeBookMax) {
                Console.WriteLine ($" Students: {student1.Key} | Max Grade: {student1.Value} ");
            }
            Console.WriteLine ($" _________________________________________________ ");

            minGrade (gradeBook, gradeBookMin);
            Console.WriteLine("MIN GRADES:");
            foreach (KeyValuePair<String, int> student2 in gradeBookMin) {
                Console.WriteLine ($" Students: {student2.Key} | Min Grade: {student2.Value} ");
            }
            Console.WriteLine ($" _________________________________________________ ");

            avgGrade (gradeBook, gradeBookAvg);
             Console.WriteLine("AVERAGE GRADES:");
            foreach (KeyValuePair<String, decimal> student3 in gradeBookAvg) {
                Console.WriteLine ($" Students: {student3.Key} | Min Grade: {student3.Value} ");
            }
            Console.WriteLine ($" _________________________________________________ ");
        }

        public static Dictionary<String, String> dataEntry (Dictionary<String, String> gradeBook, String studentInputYN) {
            //declare variables
            String studentName = " "; //key
            String studentGrades = " "; //value

            //while conditionals are true the app continues to get data
            while (true) {
                //if the user does not enter a Y || N they will be directed back here to try again
                Console.WriteLine ("Select Y to enter data, N to return calculations.");
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
                    throw new Exception ("You did not make a choice of Y or N.");
                }
            }
            return gradeBook;
        }
        public static Dictionary<String, int> maxGrade (Dictionary<String, String> gradeBook, Dictionary<String, int> gradeBookMax) {
            foreach (KeyValuePair<String, String> student in gradeBook) {
                var studentMax = student.Key;
                string[] splitMax = student.Value.Split (',');
                //assumes 1st entry could be largest
                int max1 = Convert.ToInt32 (splitMax[0]);
                //compares all entries in string []
                foreach (var maxCheck in splitMax) {
                    int splitMaxGrade = Convert.ToInt32 (maxCheck);
                    if (splitMaxGrade > max1) {
                        max1 = splitMaxGrade;
                    }
                }
                gradeBookMax.Add (studentMax, max1);
            }
            return gradeBookMax;
        }
        public static Dictionary<String, int> minGrade (Dictionary<String, String> gradeBook, Dictionary<String, int> gradeBookMin) {
            foreach (KeyValuePair<String, String> student in gradeBook) {
                var studentMin = student.Key;
                string[] splitMin = student.Value.Split (',');
                //assumes 1st entry could be smallest
                int min1 = Convert.ToInt32 (splitMin[0]);
                //compares all entries in string []
                foreach (var minCheck in splitMin) {
                    int splitMinGrade = Convert.ToInt32 (minCheck);
                    if (splitMinGrade < min1) {
                        min1 = splitMinGrade;
                    }
                }
                gradeBookMin.Add (studentMin, min1);
            }
            return gradeBookMin;
        }
        public static Dictionary<String, decimal> avgGrade (Dictionary<String, String> gradeBook, Dictionary<String, decimal> gradeBookAvg) {
            foreach (KeyValuePair<String, String> student in gradeBook) {
                var studentWAvg = student.Key;
                String[] studentAvgSplit = student.Value.Split (',');
                decimal[] studentAvg = studentAvgSplit.Select (x => Convert.ToDecimal (x)).ToArray ();
                decimal avg1 = studentAvg.Average ();
                gradeBookAvg.Add (studentWAvg, avg1);
            }
            return gradeBookAvg;
        }
    }
}