using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_Override_Demo {

    // Dog derives from Animal
    internal class Dog : Animal {

        // bool property to check if Dog is happy
        public bool IsHappy { get; set; }

        // constructor to pass the name/age to our base constructor
        // in Animal
        public Dog(string name, int age) : base(name, age) {
            // all dogs should be happy :)
            IsHappy = true;
        }

        // overriding the virtual method Eat() in the Animal class
        public override void Eat() {

            // to call the eat method from the base class 
            // use the "base" keyword
            // so this is using Animal.Eat()
            base.Eat();

            // we are using the base version of Eat() because the Dog
            // class doesn't do anything different
            // pretty much just saying whatever the base Animal class is doing is good enough
            // for the Dog class
            // or a Dog eats the same way as any other Animal
        }

        // override of virtual method MakeSound in Animal class
        public override void MakeSound() {

            // all animals make different sounds so we can't use base.MakeSound()
            // each child class of Animal will implement their own MakeSound()
            Console.WriteLine("Woof Woof!");
        }

        // override of virtual method Play in Animal class 
        public override void Play() {

            // check if the dog is happy - if yes call the Play method
            // from the base class 
            if (IsHappy) { 
                base.Play();
            }

            // even though we are calling base.Play() this is still an example of
            // overriding the base class because we've added a condition
            // this is to illustrate that you can add any logic and still call the base method
            // and that is an override 
            // you could also just not use base.Play() and have your own logic 
        }
    }
}
