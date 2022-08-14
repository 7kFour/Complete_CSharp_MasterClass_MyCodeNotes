using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Intro_Has_A_Relationships {

    // has a relationship 
    // Class X has a Class Y
    internal class CarIDinfo {

        // properties

        // every car has an IDNum and it's unique - so we'll start it
        // initialized to 0 and increment it
        public int IDNum { get; set; } = 0;

        // if no owner is provided - defaults to no owner
        public string Owner { get; set; } = "No owner";

    }
}
