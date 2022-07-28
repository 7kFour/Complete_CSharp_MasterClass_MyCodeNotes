using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Introduction {
    internal class Radio {

        // boolean to determine the state of the Radio 
        public bool IsOn { get; set; }

        // string for the brand name of the radio
        public string Brand { get; set; }

        // simple constructor
        public Radio(bool isOn, string brand) { 
            
            IsOn = isOn;
            Brand = brand;
        }

        // switch the radio on
        public void SwitchOn() {
            IsOn = true;
        }

        // switch the radio off
        public void SwitchOff() {
            IsOn = false;
        }

        // method to allow us to listen to the radio
        public void ListenRadio() {

            if (IsOn) {
                // list to the radio
                Console.WriteLine("Listening to the radio!");
            } else {
                // print error message 
                Console.WriteLine("Radio is switch off, switch it on first!");
            }
        }
    }
}
