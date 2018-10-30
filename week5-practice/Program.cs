using System;

namespace week5_practice {
    class Program {
        static void Main (string[] args) {
            //  string[][] people = new string[][]{
            //      new string [] {"first", "last", "year of birth", "gender"},
            //      new string [] {"Mike", "Doe", "1973", "Male"},
            //      new string [] {"John", "Smith", "2010", "Male"}
            //  };
            //This is a constructor  ---> |
            Person p1 = new Person("Mike", "Does");
            //p1.firstName = "Mike";
            //p1.lastName = "Doe";
            p1.yearOfBirth = 1973;
            p1.gender = 'M';
            p1.hairColor = "Brown";

            //Person.counter = 1;

            Person p2 = new Person("John", "Smith");
            //p2.firstName="John";
            //p2.lastName="Smith";

            //Person.counter = 2;

            Console.WriteLine($"p1's full name is {p1.fullName()} ");
            Console.WriteLine($"p2's full name is {p2.fullName()} ");
            Console.WriteLine(Person.genericHello());
            Console.WriteLine(p1.hello());
            Console.WriteLine($"Persons created {Person.counter}");
            //following will cause an exception
            Person p3 = new Person (null, null);
        }
    }
    //POCOS plain old C# objects > data holders

    class Person {
        public String firstName {get; private set;}
        public String lastName;
        public int yearOfBirth;
        public char gender;
        public String hairColor;

        public static int counter = 0;
        public String fullName(){
            return this.firstName +" "+ this.lastName;
        }
        public static String genericHello(){
            return "Hi how are you";
        }
        public String hello() {
            return "Hello, how are you? My name is" + fullName();
        }
        //create a Constructor - anything (code) that you want to run when instantiated.
        //if you do not create one- one comes for free "default" and does nothing
        //if you make one the default goes away
        // name must match class
        public Person(string firstName, string lastName){
            if (firstName == null || lastName== null){
                throw new Exception ("Everyone must have a first and last name.");
            }
            counter +=1;
            //this = instance of "my" class
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}