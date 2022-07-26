using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members_Finalizers_Destructors {
    internal class Members {

        // member - private field 
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field
        public int age;

        // member - property - exposes jobTitle safely 
        // properties start with a capital letter 
        public string JobTitle { 
            
            get {
                return jobTitle;
            } set {
                jobTitle = value;
            }

        // member - public method
        // can be called from other classes 
        public void Introducing (bool isFriend) {

            // if someone is a friend we can share our salary 
            // this is illustrating how to also do private things from inside a public method
            if (isFriend) {
                SharingPrivateInfo();
            } else {
                Console.WriteLine($"Hi my name is {memberName} and my job title is {jobTitle}. I'm {age} years old.");
            }
        }
        
        private void SharingPrivateInfo () {
            Console.WriteLine($"My salary is {salary}");
        }

        // member - constructor 
        public Members() {

            age = 30;
            memberName = "Anthony";
            salary = 65000;
            jobTitle = "Developer";

            Console.WriteLine("object created");
        }

        // member - finalizer or destructor 
        // destructor is created with ~ and then name of class
        // cannot be defined in a struct - only classes can have destructors
        // a class can only have a single destructor 
        // cannot be inherited or overloaded
        // cannot be called
        // when our members run out of scope this finalizer will be called
        // or is closed or deleted
        ~Members() {

            // cleanup statements
            Console.WriteLine("Desconstruction of member object");

            // don't use an empty finalizer
            // only implement them if you are going to use them for something 
            // otherwise they use up resources for nothing
            // when a class has a finalizer an entry is created in the finalizing queue 
            // when a finalizer is called the garbage collector is invoked to process the queue 
            // so this will slow your program down
        }


    }
}
