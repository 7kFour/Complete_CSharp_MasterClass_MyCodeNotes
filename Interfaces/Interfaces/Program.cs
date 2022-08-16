using System;

namespace Interfaces {

    // An interface is like a contract
    // the class that implements an interface agree to provide implementations for
    // all objects defined by the interface
    // Interface contains the contract terms, methods and properties
    // how they are implemented is up to the class that implements the interface
    // Generally their names are prefaced with an I like IEquatable 
    // Created with the interface keyword

    internal class Program {
        static void Main(string[] args) {

            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);

            // true
            Console.WriteLine(t2.Equals(t1));

            // normally if you compare 2 objects with .Equals() 
            // you would get false - because Equals() is a member of the Object class
            // and every object inherits from it 
            // but by using IEquatable<> in the Ticket class we are implementing our own 
            // Equals() 

            // basically using a specific interface that allows us to compare in our own way
            // so instead of comparing if the objects are exactly the same - like we would be if
            // using the original Object.Equals() - we are comparing if the objects are 
            // the same based on the criteria we created in Ticket.Equals()
             
        }
    }
}
