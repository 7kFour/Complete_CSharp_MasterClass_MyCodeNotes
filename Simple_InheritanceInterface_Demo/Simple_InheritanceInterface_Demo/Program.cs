using Coding.Exercise;
using System;

//Create An interface called IShootable.It will contain a method Shoot;
//Create a class Weapon with a Name attribute and method Label that will display the name of a weapon
//in the format "This is X!", where X is a name of a weapon;
//Create a class Gun that inherits from Weapon, can shoot with a "Bang!" message, has the name "Gun",
//and is able to show the label. 

namespace Coding.Exercise {

    // putting classes and interface in Program.cs for readability

    // implementing interface 
    internal interface IShootable {
        void Shoot();
    }

    // weapon class
    internal class Weapon {

        // properties
        protected string Name { get; set; }

        // constructors
        public Weapon() {
            Name = "Hammer";
        }

        // methods
        public void Label() {
            Console.WriteLine($"This is {Name}!");
        }
    }

    // Gun class inherits from Weapon and implements IShootable interface
    internal class Gun : Weapon, IShootable {

        // constructors
        public Gun() {
            Name = "Gun";
        }

        // methods
        public void Shoot() {
            Console.WriteLine("Bang!");
        }
    }

    public static class Program {
        static public void Main(string[] args) {
            // new instance 
            Gun pist = new Gun();

            // test for methods
            pist.Label();
            pist.Shoot();

            // verifying the interface and the parent class
            if (pist is IShootable && pist is Weapon)
                System.Console.WriteLine("Yes, it is my parents.");
        }
    }
}
