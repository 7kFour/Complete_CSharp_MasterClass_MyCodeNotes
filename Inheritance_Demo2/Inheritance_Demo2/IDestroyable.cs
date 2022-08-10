using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo2 {

    // Interfaces allow us to mimic multi-inheritance 

    internal interface IDestroyable {

        // property to store audio file of the destruction sound 
        string DestructionSound { get; set; }

        // method to destroy an object
        // for example could return the destroyed chair graphics
        // the objects you want to display when something is destroyed
        void Destroy();
    }
}
