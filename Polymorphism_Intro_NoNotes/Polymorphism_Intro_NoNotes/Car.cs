using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Intro_NoNotes {
    internal class Car {
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
        public void ShowDetails() {
            Console.WriteLine($"The car is {Color} and has {HP} horsepower");
        }

        public virtual void Repair() {
            Console.WriteLine("Car was repaired!");
        }
    }
}
