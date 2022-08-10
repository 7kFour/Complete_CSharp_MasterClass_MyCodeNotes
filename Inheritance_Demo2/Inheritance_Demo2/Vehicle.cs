using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo2 {
    internal class Vehicle {

        // vehicles speed
        protected float Speed { get; set; }
        // vehicles color
        protected string Color { get; set; }

        // default constructor 
        public Vehicle() {
            // speed in kph 
            Speed = 120f;
            Color = "Red";
        }

        // simple constructor
        public Vehicle(float speed, string color) {
            Speed = speed;
            Color = color;
        }
    }
}
