using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClass {
    // this class is a blueprint for a datatype
    // we've created our own datatype here
    internal class Human {
        // member variable
        // a member variable like below without the public keyword
        // is protected and not accessible outside the class
        // string firstName;

        // creating a member variable accessible outside the class
        public string firstName = string.Empty;
        public string lastName = string.Empty;
        public int age = 0;

        // mini challenge
        // create a public variable lastName of type string
        // change introduce method to print whole name
        // create two objects with full information - first and last name (and age - i added) - in main program
        // and print them out to console 

        // member method
        public void IntroduceMyself() {
            Console.WriteLine($"Hi, I'm {firstName} {lastName}, and I'm {age} years old!");
        }
    }
}
