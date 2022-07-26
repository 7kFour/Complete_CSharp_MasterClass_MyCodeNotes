using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Pt2 {
    internal class Box {

        private int height;

        public int Width { get; set; }

        public int Length { get; set; }

        // property 
        // will adjust Height member variable 
        // convention that properties start with a capital letter
        public int Height {

            get {
                return height;
            } set {
                if (value < 0) {

                    height = -value;
                } else {

                    height = value;
                }
            }
        }

        public int Volume {
            get {
                return Length * this.height * Width;
            }
        }

        public int FrontSurface {
            get {
                return this.height * Length;
            }
        }

        // constructor 
        public Box(int height, int length, int width) {
            
            this.height = height;
            // when using a property you don't need to use the this keyword 
            Width = width;
            Length = length;
        }

        public void DisplayInfo() {

            Console.WriteLine($"Length is: {Length}\nWidth is: {Width}\nHeight is: {height}\n" +
                $"Volume is: {Volume}");
        }

    }
}
