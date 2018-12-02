using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace Enums {
    public enum DaysOfTheWeek {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }

    class FindDay {
        public static int dayofweek (int d, int m, int y) {
            int[] t = {
                0,
                3,
                2,
                5,
                0,
                3,
                5,
                1,
                4,
                6,
                2,
                4
            };
            y -= (m < 3) ? 1 : 0;

            return (y + y / 4 - y / 100 + y / 400 +
                t[m - 1] + d) % 7;
        }
    }
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello User, What is your date of birth?");
            Console.WriteLine ("Use the following format: day, month, year (using numbers)");
            Console.WriteLine ("Example: 1,12,2014");
            string dob = Console.ReadLine ();
            int [] birthday = dob.Split(",").Select(n =>Int32.Parse(n.Trim())).ToArray();
            int d = birthday[0];
            int m = birthday[1];
            int y = birthday[2];
            var day = FindDay.dayofweek(d, m, y);
            //day = DaysOfTheWeek[day];
            Console.WriteLine((DaysOfTheWeek)day);
        }
    }
}