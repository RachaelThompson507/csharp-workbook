using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentList {
    public class Program {
        public static void Main () {
            List<Student> students = new List<Student> ();

            students.Add (new Student ("Chris", "123-456-7891", "123 Delany", -2990));
            students.Add (new Student ("Kevin", "512-222-2222", "435 Carolyn", -2500));
            students.Add (new Student ("Victoria", "512-827-8498", "701 Brazos St", 0));
            students.Add (new Student ("Luke", "555-555-5555", "451 Brody Ln", -500));
            students.Add (new Student ("Rachael", "123-456-7892", "123 Delany", 2990));
            students.Add (new Student ("Forest", "512-222-2223", "435 Carolyn", 2500));
            students.Add (new Student ("Sophie", "512-827-8499", "701 Brazos St", 12));
            students.Add (new Student ("Mark", "555-555-5556", "451 Brody Ln", -3500));
            students.Add (new Student ("Joel", "123-456-7896", "123 Delany", -90));
            students.Add (new Student ("Bob", "512-222-2232", "435 Carolyn", 200));
            students.Add (new Student ("David", "512-827-8998", "701 Brazos St", 5));
            students.Add (new Student ("Michelle", "555-555-5533", "451 Brody Ln", -500));

            //your code here
            //Linq query basic

            /*  it would be something like this-
                var hasBalance = from students where Student.Balance < 0 select student */

            //Linq short syntax

            var hasBalance = students.Where (b => b.Balance < 0);

            foreach (var student in hasBalance) {
                Console.WriteLine (student);

            }

        }

        public class Student {
            public string Name { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public int Balance { get; set; }

            public Student (string name, string phone, string address, int balance) {
                Name = name;
                Phone = phone;
                Address = address;
                Balance = balance;
            }

            public override string ToString() {
                return "Student: " +Name +", "+Phone+", "+Address+", "+Balance;
            }
        }
    }
}