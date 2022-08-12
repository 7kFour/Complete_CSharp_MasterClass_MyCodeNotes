using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Polymorphism_Intro {
    internal class Program { 

        // Covers polymorphism, new, sealed, virtual, override

        // Note on Virtual/Override and New 
        // Virtual/Override - override the base class but show a 'linkage' between 
        // parent and child (deriving and base) classes. The compiler knows that the child
        // class is an override of the base class

        // New - new keyword basically says that the two methods are in no way related - and the
        // method with the new keyword only exists on the child class not the parent
        // It shows no 'linkage' between the two classes 

        // when casting from a child class to a parent class the overriden method is still known 
        // but the 'new' method is not 

        // There is little reason to use new over virtual/override 
        // it breaks a core SOLID principle - the Liskov Principle
        // https://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/
        // https://dotnetcoretutorials.com/2019/10/20/solid-in-c-liskov-principle/

        // Create a base class Car with two properties HP and Color
        // a constructor to set those 2 properties
        // a method called ShowDetails() which shows the HP and Color of the car on the console
        // a Repair() method which writes "Car was repaired!" to the console
        // Create two deriving classes, BMW and Audi 
        // give them each their own constructor and and an additional property called model
        // and a private member called brand - So BMW M3 and Audo A4 make(brand)/model
        // Create two methods in each BMW and Audi - ShowDetails() and Repair() - adjusted accordingly

        static void Main(string[] args) {

            // this is where polymorphism comes into play ... 
            // eq we can use List<Car> but specify Audi and BMW within it because
            // they are both inheriting from Car
            // Audi, BMW and other classes you add that inherit from Car can be used whenever 
            // a Car type object is expected - no casting required - because an implicit 
            // conversion exists from a derived class to its base (child to parent)


            // using var because type is easy to understand from right side of = 
            // var will be type Car here
            var cars = new List<Car> {
                new Audi(602, "blue", "R8 Green Hell"),
                new BMW(689, "black", "X5 Le Mans")
            };

            // var is of type car here foreach (Car car in cars)
            // this is going to call the Repair() method in respective class of each 
            // list item ....
            // Audi was repaired!
            // BMW was repaired!
            // however if Repair() in Audi and BMW was not overriding the virtual
            // Repair() in Car - so no virtual/override keywords
            // Repair() in Car would be called and just write Car was repaired!
            // Put simply virtual method Repair is invoked on each of the derived classes
            // but not the base class
            foreach (var car in cars) {
                car.Repair();
            }

            // this is an example of how the behavior is different with the new keyword
            // being used on the methods instead of virtual/override
            // these are a BMW and Audi as a type Car - so the ShowDetails() method
            // from Car is being used because the compiler doesn't know about the ShowDetails()
            // method in Audi/BMW because new keyword doesn't keep linkage like stated above
            Car bmwZ3 = new BMW(225, "red", "Z3"); 
            Car audiA3 = new Audi(201, "white", "A3"); 

            // if virtual/override had been used these would say 'The BMW Z3 or Audi A3 instead of The car'
            bmwZ3.ShowDetails(); // The car is red and has 225 horsepower 
            audiA3.ShowDetails(); // The car is white and has 201 horsepower

            // here - even with new - since the bmwM5 variable is of type BMW we 
            // are using the ShowDetails() in BMW class because it stays its original type
            // where above BMW is being cast to type Car
            BMW bmwM5 = new BMW(330, "white", "M5");
            bmwM5.ShowDetails(); // The BMW M5 is white and has 330 horsepower

            Car carB = (Car)bmwM5;
            carB.ShowDetails(); // The car is white and has 330 horsepower
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
            // not using virtual here because new keyword is being used on Ln 91 and 114 
            // to show a different way to prioritize one method over another 
            public void ShowDetails() {
                Console.WriteLine($"The car is {Color} and has {HP} horsepower");
            }

            public virtual void Repair() {
                Console.WriteLine("Car was repaired!");
            }
        }

        class BMW : Car {
            // properties
            public string Model { get; set; }
            private string brand = "BMW";

            // constructors
            // leveraging constructor in base class for hp and color 
            public BMW(int hp, string color, string model) :base(hp, color){
                Model = model;
            }

            // methods
            // instead of using override - using new - this is saying to use this instead
            // of ShowDetails() in the base class Car
            public new void ShowDetails() {
                Console.WriteLine($"The {brand} {Model} is {Color} and has {HP} horsepower");
            }

            public override void Repair() {
                Console.WriteLine($"{brand} was repaired!");
            }
        }

        class Audi : Car {
            // properties
            public string Model { get; set; }
            private string brand = "Audi";

            // constructors
            // leveraging constructor in base class for hp and color 
            public Audi(int hp, string color, string model) :base(hp, color) {
                Model = model;
            }

            // methods
            // instead of using override - using new - this is saying to use this instead
            // of ShowDetails() in the base class Car
            public new void ShowDetails() {
                Console.WriteLine($"The {brand} {Model} is {Color} and has {HP} horsepower");
            }

            public override void Repair() {
                Console.WriteLine($"{brand} was repaired!");
            }
        }

        class M3 : BMW{

            // constructor
            public M3(int hp, string color, string model) : base(hp, color, model) {
                
            }
        }
    }
}
