using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Introduction {

    // see radio class for more detailed notes
    // wanted code to be more readable here 

    internal class TV : ElectricalDevice {

        // constructor 
        public TV(bool isOn, string brand) :base(isOn, brand) {

        }

        // method to allow us to use the device
        public void WatchTV() {

            // check if device is turned on 
            if (IsOn) {
                // use the device
                Console.WriteLine("Watching TV!");
            } else {
                // print error message 
                Console.WriteLine("TV is switched off, switch it on first!");
            }
        }
    }
}
