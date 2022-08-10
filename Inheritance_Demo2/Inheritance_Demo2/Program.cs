using System;

namespace Inheritance_Demo2 {

    // lots of notes in each file make sure to read them all 

    // Interfaces are also known as ABC or Abstract Classes 

    // Interfaces provide a lot of benefits -

    // code readability - defines the capabilities of your class, what your class 
    // is capable of doing
    // if you implement ISortable - you are clearly stating that objects of your class
    // can be sorted

    // code semantics - active separation of concepts 
    // interfaces define behavioral models, a definition of what an object can do
    // separation of concepts keep code semantics more clear

    // code maintainability - interfaces help reduce coupling
    // allow easy interchange of implementation for the same concept
    // without underlying code being affected

    // design patterns - bigger picture of using contracts, abstration
    // and using interfaces - pivotal to OOP
    // helps humans understand the code better

    // multiple inheritance - interfaces can be the gateway to using multi-inheritance
    // in C#

    // interfaces are especially useful when classes don't have a 
    // relationship with each other - ie they don't share a base class
    // so inheritance the usual way is not an option

    // interfaces are used for communication between two similar or non-similar classes
    // which do not care about the type of class implementing the interface
    // like Car communicating with Chair to call the Destroy() method

    // in this example - imagine we are working on a game where the player can
    // destroy things and each object destroyed has a different behavior
    // eg - destroying a chair will play a destruction sound, and display
    // destroyed chair parts - but destroying a car will play an explosion
    // sound, create fire, and destroy other objects nearby 

    // We can't make our classes inherit from it because C# is a single inheritance language
    // not a multi-inheritance language
    // Car : Vehicle so it can't inherit from another class same for Chair : Furniture

    // A Class in C# cannot have more than one base class (single inheritance) but
    // there is no concrete relationship between a Car and a Chair to share anyway
    // they are two entirely different things

    // what is the best approach to making the destruction feature if we can't have
    // our classes inherit from it?

    // we could implement a destroy method in each Class but that would be difficult
    // to maintain
    // so the best approach in this case would be to implement an interface

    // we will call our interface IDestroyable
    // can add an interface the same way as adding a class 
    // right click namespace in explorer > add > new item > interface

    // add an I to the beginning of your interface so that it is easier to 
    // know that its an interface

    // any class that implements this interface will be forced to follow 
    // the destruction requirements and customize it at the same time 
    // depending on the class itself

    // our classes and what they inherit from
    // Chair : Furniture 
    // Car : Vehicle 

    internal class Program {
        static void Main(string[] args) {

            // creating two objects of type Chair
            Chair officeChair = new Chair("Brown", "Wood");
            Chair gamingChair = new Chair("Red", "Plastic");

            // creating object of type Car
            Car damagedCar = new Car(80f, "Black");

            // adding chairs to the IDestroyable list of the Car class 
            // so that when the Car is destroyed - the nearby objects
            // will also be destroyed 

            // being able to add these chairs to the list also shows that since 
            // Chair is implementing IDestroyable it is accepted as an object of
            // type IDestroyable and also type Chair
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            // destroy the car
            damagedCar.Destroy();
        }
    }
}
