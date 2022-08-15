using System;

namespace AbstractClass_as_and_is_keywords {
    internal class Program {

        // the idea with the shape class is that we do not want to instantiate any shape objects
        // but we do want to instantiate objects that are types of shapes

        // abstract class - we cant create an object of it - has abstract keyword -
        // we can still use its methods and properties

        static void Main(string[] args) {

            // array of our shapes that we created
            Shape[] shapes = { new Sphere(4), new Cube(3) };

            foreach (Shape s in shapes) {
                s.GetInfo();
                Console.WriteLine($"{s.Name} has a volume of {s.Volume()}");

                // as keyword - I want the object as a specific datatype/type like saying I want n as an int, bool etc
                // but a type we created ourselves
                // create the current s as a Cube
                Cube iceCube = s as Cube;
                if (iceCube == null) {
                    Console.WriteLine("This shape is no cube!");
                }

                // is keyword - check if a variable is a certain type
                if (s is Cube) {

                    // basic example showing that you can use the is keyword to perform logic on an object
                    // like using a different calculation, or something for a game etc
                    Console.WriteLine("This shape is a cube!");
                }

                // remember - every class inherits from Object in C#
                // cast from object to cube
                // cube1 is an object that contains a cube
                object cube1 = new Cube(7);

                // this cast will only work if cube1 contains a cube
                // now cube2 is the value of cube1 as a Cube
                Cube cube2 = (Cube)cube1;

                Console.WriteLine($"{cube2.Name} cube2 has a volume of {cube2.Volume()}");
            }
        }
    }
}
