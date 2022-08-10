using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo2 {

    // subclass chair extends(inherits from) Furniture
    internal class Chair : Furniture, IDestroyable {

        // implementing the interface's property manually
        // needed to remove error
        public string DestructionSound { get; set; }

        // simple constructor
        // see car for another example of a constructor using :base()
        // using :base would negate the need for setting any properties 
        // unless they were unique to this class
        public Chair(string color, string material) {
            this.Color = color;
            this.Material = material;

            // initialize the interface's property with a value in the constructor
            // needed to remove error
            // this will always be the same in this example so it doesn't need to be
            // added as a parameter to Chair constructor
            DestructionSound = "CarExplosionSound.mp3";
        }

        // implementing the interfaces method 
        // needed to remove error 
        public void Destroy() {

            // the theory of this is actually good for a simple way of destroying objects
            // in a game when you don't have a large team 
            // create an animation for destruction and then spawn in the destroyed part
            // or parts to replace the original object

            // when a car gets destroyed - should play the destruction sound
            // and spawn destroyed chair parts 
            Console.WriteLine($"The {Color} chair was destroyed!");
            Console.WriteLine($"Playing destruction sound {DestructionSound}");
            Console.WriteLine("Spawning chair parts -- smash smash --");
        }

    }
}
