using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstractClass_as_and_is_keywords {
    internal class Sphere : Shape{
        public double Radius { get; set; }

        public Sphere(double radius) {
            Name = "Sphere";
            Radius = radius;
        }

        public override double Volume() {

            // remember order of operations
            return Math.PI * Math.Pow(Radius, 3) * 4 / 3;
        }

        public override void GetInfo() {
            base.GetInfo();

            Console.WriteLine($"The Sphere has a radius of {Radius}");
        }
    }
}
