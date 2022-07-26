using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties {
    internal class Box {

        // member variables 
        // have a direct impact on the class
        // public variables are not safe
        public int height;
        public int width;
        public int volume;

        // private member variable
        private int length; 

        // create setter for length 
        // this setter method will set the value for the length variable
        private void SetLength(int length) {

            // this.length is the length outside the scope of the method
            // it is being set to the value of the argument length
            this.length = length;
        }

        // an example to show other things you can do in a setter
        public void SetMoreLength(int length) {

            if (length < 0) {
                throw new Exception("Length should be greater than 0");
            }

            this.length = length;
        }

        // creating a getter to allow us to access a private the value to use it
        // function type must be the same as the type you want to return 
        // convention for naming getter methods - PascalCase 
        // start name with Get then add variable name - GetVariableName
        public int GetLength() {

            // you can just return `lenght` but adding this. makes it clear
            // that you are talking about the class scoped variable member variable
            return this.length;
        }

        // instead of getting direct access to the volume member variable 
        // users will get access to the return value of the GetVolume() member method
        public int GetVolume() {

            return this.length * this.height * this.width;
        }


        // will display len/wid/hght and tell us the volume of the box
        public void DisplayInfo() {
            volume = length * width * height;

            Console.WriteLine($"Length is: {length}\nHeight is: {height}\n" +
                $"Width is: {width}\nVolume is: {volume}");
        }


    }
}
