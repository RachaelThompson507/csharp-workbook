using System;

namespace week3_practice {
    class Program {
        static void Main (string[] args) {
            //Console.WriteLine("Hello World!");
            Console.WriteLine ("Please enter a number: ");
            int num1 = Convert.ToInt32 (Console.ReadLine ());
            Console.WriteLine ("Enter a second number: ");
            int num2 = Convert.ToInt32 (Console.ReadLine ());

            int sum = Add (num1, num2);

            Console.WriteLine ("The sum is: {0}", sum);

            bool allTestPassed = tests();
            if (allTestPassed ()) {
                Console.WriteLine ("Tests passed.");
            } else {
                Console.WriteLine ("Tests failed.");
            }
        }
        public static int Add (int num1, int num2) {
            return num1 + num2;
        }
        /*
        3+7 = 10
        21+(-3)= 18
        (-5)+4 = -1
        (-10)+(-14)= -24
         */
        public static bool tests () {
            return test1() && test2() && test3() && test4();
            // if (!test1 ()) {
            //     return false;
            // }
            // if (!test2 ()) {
            //     return false;
            // }
            // if (!test3 ()) {
            //     return false;
            // }
            // if (!test4 ()) {
            //     return false;
        }
        public bool test1 () {
            // int answer = 10;
            // int code = Add (3, 7);
            // if (answer == code) {
            //     return true;
            // } else {
            //     return false;
            // }
            return 10 == Add(3,7);
        }
        public bool test2 () {
            return 18 == Add (21, -3);
        }
        public bool test3 () {
            return -1 == Add (-5, 4);
        }
        public bool test4 () {
            return -24 == Add (-10, -14);
        }
        // Console.WriteLine("{0} + {1} = {2}", 3, 4, 3+4) == 7 &&
        // Console.WriteLine("{0} + {1} = {2}", 3, 3, 3+3) == 6 &&
        // Console.WriteLine("{0} + {1} = {2}", 3, 2, 3+2) == 5 &&
        // Console.WriteLine("{0} + {1} = {2}", 3, 1, 3+1) == 4;
    }
}
