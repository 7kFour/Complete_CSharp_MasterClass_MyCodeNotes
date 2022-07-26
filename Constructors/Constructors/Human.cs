using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors {
    internal class Human {
        // member variables 
        // we can change our member variables to private 
        // now that we have a constructor
        private string firstName;
        private string lastName;
        private string eyeColor;

        private int age;


        // constructor
        // important to use public or else you won't be able to use it from outside class
        // the paramters are what someone needs to input each time they create 
        // a new human object
        // showing the difference between having a differently named local variable (parameter myFirstName)
        // and using the this. keyword 
        // they do the same thing but a bit differently 
        // he likes to use this instead of changing the name
        public Human(string myFirstName, string lastName, int age, string eyeColor) {
            firstName = myFirstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor;
        }

        // member method 
        public void IntroduceMyself() {
            if (age == 1) {
                Console.WriteLine($"Hello, I'm {firstName} {lastName}, and I'm {age} year old! I have {eyeColor} eyes!");
            } else {
                Console.WriteLine($"Hello, I'm {firstName} {lastName}, and I'm {age} years old! I have {eyeColor} eyes!");
            }
        }
    }
}
