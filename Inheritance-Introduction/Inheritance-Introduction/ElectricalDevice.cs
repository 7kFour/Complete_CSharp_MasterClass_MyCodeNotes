using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Introduction {
    internal class ElectricalDevice {

        // creating this as a base/parent class 
        // all of the common functionality/properties from TV and Radio will 
        // be moved to this class and then inherited by them 

        // boolean to determine the state of the device
        public bool IsOn { get; set; }

        // string for the brand name of the device
        public string Brand { get; set; }

        // simple constructor
        public ElectricalDevice(bool isOn, string brand) {

            IsOn = isOn;
            Brand = brand;
        }

        // switch the device on
        public void SwitchOn() {
            IsOn = true;
        }

        // switch the device off
        public void SwitchOff() {
            IsOn = false;
        }


    }
}
