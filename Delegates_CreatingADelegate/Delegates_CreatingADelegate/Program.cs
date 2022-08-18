using System;
using System.Collections.Generic;
using System.Net.Cache;

namespace Delegates_CreatingADelegate {
    internal class Program {

        // defining a delegate of type called FilterDelegate that takes a person 
        // object and returns a bool
        public delegate bool FilterDelegate(Person p);

        static void Main(string[] args) {

            // creating a list of Person objects 
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            // add the objects to the list 
            List<Person> people = new List<Person>() { p1, p2, p3, p4 };

            // calling DisplayPeople method - passing "Kids", people list, and IsMinor method
            // we can pass IsMinor (or the other methods we created as filters) with no parameters
            // and no () because they match the signature for the FilterDelegate delegate
            // eg - they return a bool and have one parameter of type person
            DisplayPeople("Kids", people, IsMinor);

            DisplayPeople("Adults", people, IsAdult);

            DisplayPeople("Seniors", people, IsSenior);

        }

        // a method to display the list of people that passes the filter condition (returns true)
        // this method will take a title to be displayed, the list of people, and a filter delegate
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter) {

            // print the title
            Console.WriteLine(title);

            foreach (Person p in people) {
                // check if the person passes the filter
                if (filter(p)) {
                    // print the person's name and age 
                    Console.WriteLine($"{p.Name}, {p.Age} years old");
                }
            }
        }

        // ========= Filter methods
        
        static bool IsMinor(Person p) {

            // return a bool after checking age against 18
            return p.Age < 18;
        }

        static bool IsAdult(Person p) {

            return p.Age >= 18;
        }

        static bool IsSenior(Person p) {

            return p.Age >= 65;
        }

    }
}
