using System;
using System.Collections.Generic;

namespace week4_practice {
    class Program {
        static void Main (string[] args) {
            //Console.WriteLine("Hello World!");
            List<string> names = new List<string> { "Bob", "Johnny", "Jack", "Mark", "Joy", "Rachael" };
            foreach (string name in names) {
                Console.WriteLine (name);
            }
            Stack<String> names1 = new Stack<String> ();
            names1.Push ("Bob");
            names1.Push ("Johnny");
            names1.Push ("Jack");
            names1.Push ("Mark");
            names1.Push ("Joy");
            names1.Push ("Rachael");
            foreach (String name1 in names1) {
                Console.WriteLine (name1);
            }
            while (names1.Count > 0) {
                String currentName = names1.Pop ();
                Console.WriteLine ("Processing" + currentName);
            }
            //stacks help with depth vs breadth
            Console.WriteLine ("Stack size" + names1.Count);

            Dictionary<String, int> grades = new Dictionary<string, int> ();
            grades.Add("Jane", 75);
            grades.Add("Mark", 33);
            grades.Add("Mike", 45);
            grades.Add("June", 33);
                Console.WriteLine(grades["June"]);
            Dictionary<int, String> item = new Dictionary<int, String> ();
            item.Add(6615472954, "Rachael");
        }
    }
}