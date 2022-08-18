using System;
using System.Collections.Generic;

namespace Delegates_Demo {
    internal class Program {

        // A delegate is a type that can hold a reference to a method 
        // when you call the delegate the method stored as a reference will be called 
        // The stored method must be return type void and take no parameters
 
        static void Main(string[] args) {

            // list of names 
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };

            Console.WriteLine("----before----");
            // print the names before remove all method
            foreach (string n in names) {
                Console.WriteLine(n); // prints all names
            }

            // calling RemoveAll and passing a method Filter we created 
            // Predicate<t> in RemoveAll is a delegate
            // notice when using Filter we don't add () - we are actually passing Filter 
            // as a parameter to RemoveAll()
            names.RemoveAll(Filter);

            Console.WriteLine("----after----");
            // print names after the remove all method
            foreach (string n in names) {
                Console.WriteLine(n); // only prints walter
            }
        }

        // a method called Filter that takes a string
        static bool Filter(string s) {
            // return whether the string s contains the letter 'i' as a bool
            // the Contains method will return a bool which we will return as well
            return s.Contains("i");
        }
    }
}
