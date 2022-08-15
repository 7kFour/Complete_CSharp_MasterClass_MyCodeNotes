using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_as_and_is_keywords {
    abstract class Shape {
        public string Name { get; set; }

        // virtual keyword to allow this base class method to be overriden in a derived class
        public virtual void GetInfo() {
            Console.WriteLine($"\nThis is a {Name}");
        }

        // abstract method - we don't implement it here
        // this is saying that whenever a class wants to inherit from Shape
        // it needs to include functionality for the method Volume();
        public abstract double Volume();
    }
}
