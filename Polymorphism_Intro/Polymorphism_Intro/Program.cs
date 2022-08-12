using System;
using System.Runtime.InteropServices;

namespace Polymorphism_Intro {
    internal class Program {

        // Create a base class Car with two properties HP and Color
        // a constructor to set those 2 properties
        // a method called ShowDetails() which shows the HP and Color of the car on the console
        // a Repair() method which writes "Car was repaired!" to the console
        // Create two deriving classes, BMW and Audi 
        // give them each their own constructor and and an additional property called model
        // and a private member called brand - So BMW M3 and Audo A4 make(brand)/model
        // Create two methods in each BMW and Audi - ShowDetails() and Repair() - adjusted accordingly

        static void Main(string[] args) {

            BMW b = new BMW(100, "black", "X5 Le Mans");
            Audi a = new Audi(90, "blue", "R8 Green Hell");

            a.ShowDetails();
            a.Repair();

            b.ShowDetails();
            b.Repair();
        }

        // creating classes in Program.cs for ease of reading notes 

        class Car {
            // properties
            public int HP { get; set; }
            public string Color { get; set; }

            // constructors
            public Car(int hp, string color) {
                HP = hp;
                Color = color;
            }

            // methods
            public virtual void ShowDetails() {
                Console.WriteLine($"The car is {Color} and has {HP} hit points");
            }

            public virtual void Repair() {
                Console.WriteLine("Car was repaired!");
            }
        }

        class BMW : Car {
            // properties
            public string Model { get; set; }
            protected string brand = "BMW";

            // constructors
            // leveraging constructor in base class for hp and color 
            public BMW(int hp, string color, string model) :base(hp, color){
                Model = model;
            }

            // methods
            public override void ShowDetails() {
                Console.WriteLine($"The {brand} {Model} is {Color} and has {HP} hit points");
            }

            public override void Repair() {
                Console.WriteLine($"{brand} was repaired!");
            }
        }

        class Audi : Car {
            // properties
            public string Model { get; set; }
            protected string brand = "Audi";

            // constructors
            // leveraging constructor in base class for hp and color 
            public Audi(int hp, string color, string model) :base(hp, color) {
                Model = model;
            }

            // methods
            public override void ShowDetails() {
                Console.WriteLine($"The {brand} {Model} is {Color} and has {HP} hit points");
            }

            public override void Repair() {
                Console.WriteLine($"{brand} was repaired!");
            }
        }
    }
}
