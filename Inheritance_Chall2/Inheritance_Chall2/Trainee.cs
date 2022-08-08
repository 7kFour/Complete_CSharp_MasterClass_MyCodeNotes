using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Chall2 {
    internal class Trainee : Employee {

        // unique class properties
        protected string WorkingHours { get; set; }
        protected string SchoolHours { get; set; }

        // constructors
        public Trainee() { }

        public Trainee(string last, string first, int pay, string workhours, string schoolhours) :base(last, first, pay) {
            this.WorkingHours = workhours;
            this.SchoolHours = schoolhours;
        }

        // methods 
        public void Learn() {
            Console.WriteLine($"Probably learning... it's {SchoolHours}");
        }

        public override void Work() {
            Console.WriteLine($"My work hours are {WorkingHours}");
        }

        public override void Pause() {
            base.Pause();
        }
    }
}
