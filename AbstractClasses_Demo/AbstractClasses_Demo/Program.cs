using System;

namespace AbstractClasses_Demo {
    internal class Program {

        // the idea with the shape class is that we do not want to instantiate any shape objects
        // but we do want to instantiate objects that are types of shapes

        // abstract class - we cant create an object of it - has abstract keyword -
        // we can still use its methods and properties


        static void Main(string[] args) {

            // array of our shapes that we created
            Shape[] shapes = { new Sphere(4), new Cube(3) };

            foreach (Shape shape in shapes) {
                shape.GetInfo();
                Console.WriteLine($"{shape.Name} has a volume of {shape.Volume()}");
            }
        }
    }
}
