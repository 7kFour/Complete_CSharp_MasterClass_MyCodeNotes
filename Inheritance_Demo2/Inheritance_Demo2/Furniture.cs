using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo2 {
    internal class Furniture {

        // color of furniture
        protected string Color { get; set; }
        // material of furniture
        protected string Material { get; set; }

        // default constructor
        public Furniture() {
            Color = "Brown";
            Material = "Wood";
        }

        // simple constructor
        public Furniture(string color, string material) {

            Color = color;
            Material = material;
        }


    }
}
