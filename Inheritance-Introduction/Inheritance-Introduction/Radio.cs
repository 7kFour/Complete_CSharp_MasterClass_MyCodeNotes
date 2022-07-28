using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Introduction {
    // <class you are in> : <the name of the class you want to extend>
    // Radio : ElectricalDevice <-- Radio is no inheriting from (or extending)
    // ElectricalDevice
    // the class you want to inherit from either needs to be in the same namespace
    // or you need to add it's namespace in using at the top 

    internal class Radio : ElectricalDevice {

        // constructor -- using :base keyword to pass the 
        // base class its arguments
        // so base :base is passing whatever arguments are passed to 
        // Radio() when a new Radio object is created to 
        // the ElectricalDevice class - because we set it with 
        // : on Line 14
        public Radio(bool isOn, string brand):base(isOn, brand) {
            // the :base() is basically taking care of the below code 
            // so we don't need a body for the constructor 
            //IsOn = isOn;
            //Brand = brand;
        }

        // method to allow us to use the device
        public void ListenRadio() {

            // check if device is turned on 
            if (IsOn) {
                // use the device
                Console.WriteLine("Listening to the radio!");
            } else {
                // print error message 
                Console.WriteLine("Radio is switched off, switch it on first!");
            }
        }
    }
}
