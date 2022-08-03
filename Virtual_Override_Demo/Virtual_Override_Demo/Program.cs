using System;

namespace Virtual_Override_Demo {
    internal class Program {
        static void Main(string[] args) {

            // create a new Dog object 
            Dog buster = new Dog("Buster", 8);

            Console.WriteLine($"{buster.Name} would be {buster.Age} years old!");

            buster.MakeSound();
            buster.Eat();
            buster.Play();
        }
    }
}
