using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleConstructors {
    internal class Human {
        //member variables 
        private string firstName;
        private string lastName;
        private string eyeColor;

        private int age;

        // default constructor
        public Human() {
            Console.WriteLine("Constructor called. Object created.");
        }

        // parameterized constructors
        public Human(string firstName, string lastName, string eyeColor, int age) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.eyeColor = eyeColor; 
        }

        public Human(string firstName, string lastName, string eyeColor) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        public Human(string firstName, string lastName, int age) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Human(string firstName, string lastName) {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Human(string firstName) {
            this.firstName = firstName;
        }

        // member method
        public void IntroduceMyself() {
            if (age != 0 && !string.IsNullOrEmpty(eyeColor) && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName)) {
                Console.WriteLine($"Hello, I'm {firstName} {lastName}, and I'm {age} years old!. I have {eyeColor} eyes!");

            } else if (!string.IsNullOrEmpty(eyeColor) && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName)) {
                Console.WriteLine($"Hello, I'm {firstName} {lastName}. I have {eyeColor} eyes!");

            } else if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && age != 0) {
                Console.WriteLine($"Hello, I'm {firstName} {lastName}, and I'm {age} years old!");

            } else if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName)) {
                Console.WriteLine($"Hello, I'm {firstName} {lastName}");

            } else if (!string.IsNullOrEmpty(firstName)){
                Console.WriteLine($"Hello, I'm {firstName}");

            } else {
                Console.WriteLine("No values entered to introduce myself with!");
            }
        }
    }
}
