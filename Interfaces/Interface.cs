using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Plane x = new Plane ();
            Console.WriteLine(x.Fly());
            Console.WriteLine(x.Wings());
            Bird y = new Bird ();
            Console.WriteLine(y.Fly());
            Console.WriteLine(y.Wings());
            Pterodactyl p = new Pterodactyl ();
            Console.WriteLine(p.Fly());
            Console.WriteLine(p.Wings());

        }
    }
    interface IThingsThatFly
    {
        string Fly();
        string Wings();
    }

    class Plane : IThingsThatFly
    {
        public string Fly (){
            return "Planes fly!";
        }
        public string Wings(){
            return "Planes have wings!";
        }
    }
    class Bird : IThingsThatFly
    {
       public string Fly (){
            return "Birds  fly!";
        }
        public string Wings(){
            return "Birds have wings!";
        }
    }
    class Pterodactyl : IThingsThatFly
    {
        public string Fly (){
            return "Pterodactyls fly!";
        }
        public string Wings(){
            return "Pterodactyls have wings!";
        }
    }
}
