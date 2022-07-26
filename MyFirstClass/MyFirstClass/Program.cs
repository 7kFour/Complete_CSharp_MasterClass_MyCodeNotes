using System;

namespace MyFirstClass {
    internal class Program {
        static void Main(string[] args) {
            // create an object of my class
            // also called an instance of <class name> 
            // so anthony is an instance of Human            
            Human anthony = new Human();

            // access public member variable from outside class
            // can even change it
            anthony.firstName = "Anthony";
            anthony.lastName = "Spradlin";
            anthony.age = 36;
            // call methods of the class
            anthony.IntroduceMyself();

            // this won't show a name because we haven't set it yet
            Human amber = new Human();
            amber.firstName = "Amber";
            amber.lastName = "Spradlin";
            amber.age = 33;
            amber.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
