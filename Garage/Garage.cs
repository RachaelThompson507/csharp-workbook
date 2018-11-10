using System;

public class Program {

    public static void Main () {
        // instantiating a new instance of car, and  passing "blue" to the constructor;
        Car blueCar = new Car ("blue", 4);
        Car goldCar = new Car ("gold", 2);
        Person rachael = new Person ("Rachael");
        Person corey = new Person ("Corey");

        //put people in cars
        try {
            blueCar.peopleInCar(rachael, 0);
            goldCar.peopleInCar(corey, 0);
        } catch (System.ArgumentException e){
            Console.WriteLine ("Exception Caught: {0}", e);
        } finally {
            Console.WriteLine (blueCar.Persons);
            Console.WriteLine (goldCar.Persons);
        }

        // instantiating a new instaice of Garage class, and passing in 2 to the constructor;
        Garage smallGarage = new Garage (2);

        // calling a method Parkcar of the smallGarage instance, with inputs of blueCar and 0
        try {
            smallGarage.ParkCar (blueCar, 0);
            smallGarage.ParkCar (goldCar, 1);
        } catch (System.ArgumentException e) {
            Console.WriteLine ("Exception Caught: {0}", e);
        } finally {
            // printint out the cars attribute of the small garage
            Console.WriteLine (smallGarage.Cars);
        }
    }
}

class Car {
    // constructor
    // takes in a strin that is the intial string
    public Car (string initialColor, int seatsTaken) {
        // setting the color of the car to be the string passed into the constructor
        Color = initialColor;
         // setting the size of this car
        Seats = seatsTaken;
        // instantiating an array of Cars, of size initialsize
        this.persons = new Person[seatsTaken];
    }

    // changes the color of the car, even though it is a private attribute/variable
    public void paintTheCar (String newColor) {
        Color = newColor;
    }

    // once the color is set i cannt change it, outisde of this class
    public string Color { get; private set; }

    private Person [] persons;

    public int Seats {get; private set;}

    public void peopleInCar (Person person, int seats) {
        if (persons[seats] == null) {
            persons[seats] = person;
        } else if (persons[seats] != null) {
            throw new System.ArgumentException ("You cannot sit here, this seat is taken.");
        } else {
            throw new System.ArgumentException ("You have made a choice that is outside of the car.");
        }
    }
    public string Persons {
        get {
            String personsString = "";
            String carColor = Color;
            for (int i = 0; i < persons.Length; i++) {
                if (persons[i] != null) {
                    personsString += String.Format ("The {0} is in seat {1} of the {2} car.", persons[i].Name, i + 1, carColor);
                    //personsString += "\n";
                }
            }
            return personsString;
        }
    }
}
class Person {
    //constructor
    public Person (String name) {
        Name = name;
    }
    public String Name {get; set;}
}

class Garage {
    // an array of cars ? what does this do? why is it here?

    private Car[] cars;

    // constructor , int of initial size
    public Garage (int initialSize) {
        // setting the size of this garage
        Size = initialSize;
        // instantiating an array of Cars, of size initialsize
        this.cars = new Car[initialSize];
    }

    //attribute , private for number of slots in the garage.
    public int Size { get; private set; }

    // a method that adds a car to the spot in the cars array
    public void ParkCar (Car car, int spot) {
        if (cars[spot] == null) {
            cars[spot] = car;
        } else if (cars[spot] != null) {
            throw new System.ArgumentException ("You cannot park here, this spot is taken.");
        } else {
            throw new System.ArgumentException ("You have made a choice that is outside of the garage.");
        }
    }

    public string Cars {
        get {
            String carsString = "";
            for (int i = 0; i < cars.Length; i++) {
                if (cars[i] != null) {
                    carsString += String.Format ("The {0} car is in spot {1}.", cars[i].Color, i + 1);
                    carsString += "\n";
                }
            }
            return carsString;
        }
    }
}