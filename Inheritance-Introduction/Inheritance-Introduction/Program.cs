using System;

namespace Inheritance_Introduction {
    internal class Program {
        static void Main(string[] args) {

            // radio and tv are child classes
            // electricaldevice is the parent class
            // children inherit from parents

            // create a radio object
            Radio myRadio = new Radio(false, "Sony");

            // method of parent class
            myRadio.SwitchOn();
            // method of child class
            myRadio.ListenRadio();

            // create a TV object
            TV myTV = new TV(true, "Samsung");

            // method of parent class
            myTV.SwitchOff();
            // method of child class
            myTV.WatchTV(); 

            // the radio and tv classes don't have SwitchOn() and SwitchOff()
            // but they can still use them because they are inheriting 
            // them from ElectricalDevice
        }
    }
}
