using System;

namespace Structs {

    // Structs are very similar to classes but Structs are value types 
    // and classes are reference types
    // ie an object of a class can be empty but a struct has to have a value

    // structs also differ from classes in that they cannot have explicit parameterless (default) constructors
    //  they can however have defined constructors - constructors with parameters 
    // structs can implement interfaces
    // structs do not support inheritance 
    // struct members cannot be specified as abstract, virtual or protected (they can only be public or private)
    // all values in a struct need to be defined otherwise you will get an error 
    // try running the Display() method in between game1.developer and game1.rating on ln24 you'll get an error

    // Classes
    // can support inheritance
    // are reference (pointer) types
    // reference can be null
    // have memory overhead per new instance

    // Structs
    // can't support inheritance
    // are passed by value (like integers)
    // can't have a null reference (unless Nullable is used)
    // do not have memory overheard per new instance - unless 'boxed'

    // Both Classes and Structs
    // are compound data types typically used to contain a few variables that have some logical relationship
    // can contain methods and events
    // can support interfaces

    internal class Program {
        static void Main(string[] args) {

            Game game1;

            game1.name = "Elden Ring";
            game1.developer = "FromSoft";
            game1.rating = 91.33;
            game1.releaseDate = "2022";

            Console.WriteLine($"{game1.name} was developed by {game1.developer}.\n" +
                $"It released in {game1.releaseDate} and currently has a {game1.rating} rating.");

            // you can also add methods to a struct see Display()
            game1.Display();





            Console.ReadLine();
        }
    }

    // creating struct in same file for readability 
    // normally give them their own file like a class

    struct Game {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        // can't have default constructor
        //public Game() {
        // this wont work
        //}

        // can have parameter constructors
        public Game(string n, string d, double r, string rd) {
            name = n;
            developer = d;
            rating = r;
            releaseDate = rd;
        }

        // adding a display struct to demonstrate functionality
        public void Display() {
            Console.WriteLine("\nThis is from the Display() Method!");
            Console.WriteLine($"{name} was developed by {developer}.\n" +
                 $"It released in {releaseDate} and currently has a {rating} rating.");
        }
    }
}
