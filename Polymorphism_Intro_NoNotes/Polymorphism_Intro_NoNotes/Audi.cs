using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Intro_NoNotes {
    internal class Audi : Car {
        // properties
        public string Model { get; set; }
        private string brand = "Audi";

        // constructors
        // leveraging constructor in base class for hp and color 
        public Audi(int hp, string color, string model) : base(hp, color) {
            Model = model;
        }

        // methods
        // instead of using override - using new - this is saying to use this instead
        // of ShowDetails() in the base class Car
        public new void ShowDetails() {
            Console.WriteLine($"The {brand} {Model} is {Color} and has {HP} horsepower");
        }

        public override void Repair() {
            Console.WriteLine($"The {brand} {Model} was repaired!");
        }
    }
}
