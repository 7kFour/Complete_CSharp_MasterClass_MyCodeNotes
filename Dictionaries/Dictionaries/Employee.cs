using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries {
    internal class Employee {

        public string Role { get; set; }

        public string Name { get; set; }
        
        public int Age { get; set; }

        public float Rate { get; set; }

        // yearly Salary = rate * hours * number of days * number of weeks * number of months
        public float Salary { 
            get {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        // constructor 
        public Employee(string role, string name, int age, float rate) {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate; 
        }
    }
}
