using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
/*
Give a name to the Ship - added to Ship Class (X)
Create a Station class that has a name, alliance, and a set number of ships. (X)
Be able to set the name and alliance (in case it's captured), (X)
and be able to dock ships into a port location (index) and let them leave.
Also have a Roster property that lists all the ships and people in the ships on the station.
 */
public class Program {
    public static void Main () {
        //variables
        Person leia = new Person ("Leia", "Organa", "Rebel");
        Person darth = new Person ("Darth", "Vader", "Imperial");
        Ship falcon = new Ship ("Millennium Falcon", "Rebel", "Smuggling", 2);
        Ship tie = new Ship ("Tie Fighter", "Imperial", "Fighter", 1);
        Ship xwing = new Ship ("X Wing", "Rebel", "Fighter", 1);
        Station class1 = new Station ("Class 1", "Rebel", 2);
        Station deathStar = new Station ("Death Star", "Imperial", 2);

        //place people onto ships

        //place ships onto stations

        //roll call for each station

    }
}
//creates a person with a first & last name, their alliance
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
//creates ships that can hold people, Type and Alliance can be changed.
//Passenger allows you to see who is onboard the ship
class Ship {
    private string name;
    private Person[] passengers;
    public Ship (string name, string alliance, string type, int size) {
        this.name = name;
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
                return String.Format ("{0}", person.FullName);
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
//creates a station with a station name, alliance and port size
//you can enter a station, leave a station- upon entering or leaving you need to update the roster.
class Station {
    public string StationName;
    private Ship [] port;
    public Station (string StationName, string alliance, int spot) {
        this.StationName = StationName;
        this.Alliance = alliance;
        this.port = new Ship[spot];
    }
    public string station {
        get;
        set;
    }
    public string Alliance {
        get;
        set;
    }
    public void EnterStation (Ship name, int spot) {
        this.port[spot] = name;
    }

    public void ExitStation (int spot) {
        this.port[spot] = null;
    }
    //roster will have the passengers by ship enterStation
    public string Roster () {
        foreach () {

        }
        return ;
    }
}