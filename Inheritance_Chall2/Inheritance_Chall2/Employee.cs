using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Chall2 {



    internal class Employee {

        // employee info properties 
        // protected can only be access by parent class or child of parent
        protected string LastName { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }
        
        // constructors
        // need a default constructor to fix no argument error in deriving classes
        // and/or have a constructor in each class - good to have a default though
        public Employee() {
            this.LastName = "Doe";
            this.FirstName = "John";
            this.Salary = 0;
        }

        public Employee(string last, string first, int pay) {
            this.LastName = last;
            this.FirstName = first;
            this.Salary = pay;
        }

        // member methods
        public virtual void Work() {
            Console.WriteLine("I'm working, what do you want?");
        }

        public virtual void Pause() {
            Console.WriteLine("Nah, I'm on break.");
        }

    }
}
