using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Chall2 {
    internal class Boss : Employee {

        // unique class properties
        protected string CompanyCar { get; set; }

        // constructors
        public Boss() { }

        // instead of putting this.LastName = last; etc you can use :base(arguments)
        // basically saying use those things from the constructor in the parent class
        // and also add whatever is in my body - ie this.CompanyCar = car;
        public Boss(string last, string first, int pay, string car) :base(last, first, pay) {
            this.CompanyCar = car;
        }

        // member methods
        public void Lead() {
            Console.WriteLine("They got me out here, leading by example.");
            Console.WriteLine($"Driving my {CompanyCar} ain't easy on {Salary}... but I'm {FirstName}, I'll be alright.");
        }

        public override void Work() {
            base.Work();
        }

        public override void Pause() {
            base.Pause();
        }
    }
}
