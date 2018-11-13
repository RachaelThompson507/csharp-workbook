using System;
using System.Collections;
using System.Collections.Generic;

namespace week7_practice {
    class Program {
        static void Main (string[] args) {
            Human rachael = new Human ("Rachael", "female");
            SuperHuman superman = new SuperHuman ("Clark Kent", "male", "everything");

        }
    }
    class Human {
        public String name { get; set; }
        public String gender { get; set; }

        public Human (string name, string gender) {
            this.name = name;
            this.gender = gender;
        }
        virtual
        public string greetings () {
            return "Hi, my name is " + name;
        }
    }
    class SuperHuman : Human {
        public String superPower { get; set; }
        public SuperHuman (string name, string gender, string superPower) : base (name, gender) {
            // this.name = name;
            // this.gender = gender;
            this.superPower = superPower;
        }
        override
        public String greetings () {
            return "Hi my name is " + name + " and my superpower is " + superPower;
        }
    }
}