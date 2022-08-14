using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Polymorphism_Intro_NoNotes {
    internal class Program {

        static void Main(string[] args) {

            // using var because type is easy to understand from right side of = 
            // var will be type Car here
            var cars = new List<Car> {
                new Audi(602, "blue", "R8 Green Hell"),
                new BMW(689, "black", "X5 Le Mans")
            };

            // var is of type car here foreach (Car car in cars)
            // this is going to call the Repair() method in respective class of each 
            // list item ....
            // The Audi R8 Green Hell was repaired!
            // The BMW X5 Le Mans was repaired!
            foreach (var car in cars) {
                car.Repair();
            }

            // this is an example of how the behavior is different with the new keyword
            // being used on the methods instead of virtual/override
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

            M3 myM3 = new M3(260, "red", "M3");
            // calling the Repair() of BMW it's parent because we override and use base.Repair() in M3
            myM3.Repair(); // The BMW M3 was repaired!
            myM3.ShowDetails(); // The BMW M3 is red and has 260 horsepower

        }
    }
}
