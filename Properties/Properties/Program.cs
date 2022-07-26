using System;

namespace Properties {
    internal class Program {
        static void Main(string[] args) {
            // creating an instance of the box class
            // a variable of type Box
            Box theBox = new Box();

            // setting values in the Box class
            // only possible to do it this way because the
            // variables are public 
            theBox.height = 4;
            theBox.width = 5;

            // so we can't get or set the length 
            // theBox.length = 3; <-- cant change (set) this because it's private now
            // Console.WriteLine($"Box length is: {theBox.length}"); <-- can't get the variable to read it

            // changing the length of the box with the setter method we created
            // this is more secure than having access to the variable itself
            // theBox.SetLength(4); <-- this won't work now that the setter is private 

            // using a getter to access a value in a private variable
            Console.WriteLine($"Length from getter is: {theBox.GetLength()}\n");

            // using getter to access volume value 
            Console.WriteLine($"Volume from getter is: {theBox.GetVolume()}\n");


            theBox.DisplayInfo();

            Console.Read();
        }
    }
}
