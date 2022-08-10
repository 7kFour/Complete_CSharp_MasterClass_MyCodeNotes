using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo2 {

    // car inherits from vehicle
    // when you , IDestroyable you'll get an error about not implementing ...
    // you can either click and implement all members explicitly or
    // type in the code yourself 
    internal class Car : Vehicle, IDestroyable {

        // anything that says needed to remove error is there to remove the
        // errors you get when implementing the interface originally 
        // ie you need to implement all of the interfaces memebers in your class or 
        // you get an error 

        // implementing the interface's property manually
        // needed to remove error
        public string DestructionSound { get; set; }

        // create new property to store the destroyable objects nearby
        // when a car is destroyed it also destroys nearby objects
        // this list is of type IDestroyable - it can store any object that
        // implements the IDestroyable interface and we can only access the 
        // properties and methods in this interface
        // needed to remove error
        public List<IDestroyable> DestroyablesNearby;

        // simple constructor using :base() 
        // see chair for another example of how a constructor can send 
        // values to its parent
        public Car(float speed, string color) :base(speed, color) {

            // initialize the interface's property with a value in the constructor
            // needed to remove error
            DestructionSound = "CarExplosionSound.mp3";

            // initialize list of destroyable objects
            // needed to remove error
            DestroyablesNearby = new List<IDestroyable>();
        }

        // implementing the Destroy() method from interface 
        // needed to remove error
        public void Destroy() {

            // when a car gets destroyed play the destruction sound
            Console.WriteLine($"Playing destruction sound {DestructionSound}");
            // create a fire effect 
            Console.WriteLine($"Create a fire -- crackle crackle --");

            // destroy all of the destroyable objects nearby
            foreach (IDestroyable destroyable in DestroyablesNearby) { 
                destroyable.Destroy();
            }
        }

        // implemented with VS auto fix --- for illustration
        //string IDestroyable.DestructionSound { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //void IDestroyable.Destroy() {
        //    throw new NotImplementedException();
        //}
    }
}
