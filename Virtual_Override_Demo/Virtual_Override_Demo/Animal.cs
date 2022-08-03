using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Override_Demo {
    internal class Animal {
        // method called MakeSound() Eat() Play()

        // properties
        // if you want to do anything custon you will need member variables to 
        // return or operate on in get/set
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        // constructor 
        public Animal(string name, int age) {
            Name = name;
            Age = age;
            // all our animals are hungry by default
            IsHungry = true;
        }

        // member methods
        // virtual methods can be overwritten by classes that inherit from Animal
        // eg virtual methods can be overwritten by derivative/children classes of the class
        // with the virtual methods
        public virtual void MakeSound() {

        }

        // another virtual method which sub classes can override
        // if it isn't overriden it will function as written below by default
        public virtual void Eat() {
            // check if animal is hungry
            if (IsHungry) {
                // if yes then print name of the animal + "is eating"
                Console.WriteLine($"{Name} is eating.");
            } else {
                // otherwise print that animal is not hungry
                Console.WriteLine($"{Name} isn't hungry right now.");
            }
        }

        public virtual void Play() {
            Console.WriteLine($"{Name} is playing!");
        }
    }
}
