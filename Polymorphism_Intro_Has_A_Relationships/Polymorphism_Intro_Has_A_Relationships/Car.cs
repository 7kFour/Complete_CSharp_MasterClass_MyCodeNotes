using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Intro_Has_A_Relationships {
    internal class Car {
        // properties
        public int HP { get; set; }
        public string Color { get; set; }

        // creating Has A relationship
        // IDNum and Owner come from CarIDinfo class
        protected CarIDinfo carIDinfo = new CarIDinfo();

        public void SetCarIDInfo(int idnum, string owner) {
            carIDinfo.IDNum = idnum;
            carIDinfo.Owner = owner;
        }
        // can adjust info for any car with this - BMW, Audi M3 etc 
        public void GetCarIDInfo() {
            Console.WriteLine($"The car has the ID of {carIDinfo.IDNum} and is owned by {carIDinfo.Owner}");
        }

        // constructors
        public Car(int hp, string color) {
            HP = hp;
            Color = color;
        }

        // methods
        // not using virtual here because new keyword is being used on Ln 91 and 114 
        public void ShowDetails() {
            Console.WriteLine($"The car is {Color} and has {HP} horsepower");
        }

        public virtual void Repair() {
            Console.WriteLine("Car was repaired!");
        }
    }
}
