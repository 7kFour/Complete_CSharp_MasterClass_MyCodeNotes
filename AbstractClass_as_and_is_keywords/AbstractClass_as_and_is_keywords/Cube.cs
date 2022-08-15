using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstractClass_as_and_is_keywords {
    internal class Cube : Shape {
        // property for length
        public double Length { get; set; }

        // basic constructor
        // using Name from Shape class
        public Cube(double length) {
            Name = "Cube";
            Length = length;
        }

        // adding functionality for Volume() to fulfill requirements to inherit
        // from Shape class
        public override double Volume() {

            // Length * Length * Length
            return Math.Pow(Length, 3);
        }

        // override GetInfo() from Shape
        public override void GetInfo() {
            // will execute whatever happens in the GetInfo() method in Shape
            // but will also execute whatever logic is added in this method after
            base.GetInfo();

            // this will also get executed
            Console.WriteLine($"The Cube has a length of {Length}");
        }
    }
}
