using System;
/*
Give a name to the Ship - added to Ship Class
Create a Station class that has a name, alliance, and a set number of ships.
Be able to set the name and alliance (in case it's captured),
and be able to dock ships into a port location (index) and let them leave.
Also have a Roster property that lists all the ships and people in the ships on the station.
 */
public class Program {
    public static void Main () {
        Person leia = new Person ("Leia", "Organa", "Rebel");
        Person darth = new Person ("Darth", "Vader", "Imperial");
        Ship falcon = new Ship ("Millennium Falcon","Rebel", "Smuggling", 2);
        Ship tie = new Ship ("Tie Fighter","Empire", "Fighter", 1);
        Ship xwing = new Ship ("X Wing","Rebel", "Fighter", 1);
        // Console.WriteLine ("Hello world!");
    }
}

class Person {
    private string firstName;
    private string lastName;
    private string alliance;
    public Person (string firstName, string lastName, string alliance) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.alliance = alliance;
    }

    public string FullName {
        get {
            return this.firstName + " " + this.lastName;
        }

        set {
            string[] names = value.Split (' ');
            this.firstName = names[0];
            this.lastName = names[1];
        }
    }
}

class Ship {
    private Person[] passengers;
    public Ship (string shipName, string alliance, string type, int size) {
        this.shipName = shipName;
        this.Type = type;
        this.Alliance = alliance;
        this.passengers = new Person[size];
    }

    public string Type {
        get;
        set;
    }

    public string Alliance {
        get;
        set;
    }

    public string Passengers {
        get {
            foreach (var person in passengers) {
                Console.WriteLine (String.Format ("{0}", person.FullName));
            }

            return "That's Everybody!";
        }
    }

    public void EnterShip (Person person, int seat) {
        this.passengers[seat] = person;
    }

    public void ExitShip (int seat) {
        this.passengers[seat] = null;
    }
}
class Station {
    
}