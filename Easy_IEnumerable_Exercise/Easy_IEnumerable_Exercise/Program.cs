using System;
using System.Collections;
using System.Collections.Generic;

namespace Easy_IEnumerable_Exercise {
    // TODO
    // create Contact and PhoneBook classes in a way that will allow the 
    // Main method provided to function properly 
    // Use the contact list
    //new Contact("Andre", "435797087"),
    //                new Contact("Lisa", "435677087"),
    //                new Contact("Dine", "3457697087"),
    //                new Contact("Sofi", "4367697087")
    //            };
    // method should be named Call and should print "Calling to X. Phone numer is Y"
    // where X is name and Y is phone number

    public static class Program {
        static public void Main(string[] args) {
            PhoneBook MyPhoneBook = new PhoneBook();

            foreach (Contact contact in MyPhoneBook) {
                contact.Call();
            }
        }
    }

    class Contact { 
        
        public string Name { get; set; }
        public string Number { get; set; }

        public Contact(string name, string number) {
            Name = name;
            Number = number;
        }

        public void Call() {
            Console.WriteLine($"Calling to {Name}. Phone number is {Number}");
        }
    }

    // want to be able to iterate through Contacts so creating 
    // a list of IEnumerable<Contact>
    class PhoneBook : IEnumerable<Contact> {

        // declaring a list of Contacts for the constructor
        // to initialize
        public List<Contact> theList;

        // basic constructor - initializes List<T> collection
        public PhoneBook() {
            theList = new List<Contact>() {
                    new Contact("Andre", "435797087"),
                    new Contact("Lisa", "435677087"),
                    new Contact("Dine", "3457697087"),
                    new Contact("Sofi", "4367697087")
            };
        }

        public IEnumerator<Contact> GetEnumerator() {
            return theList.GetEnumerator();
        }

        // not using a non-generic so don't need to implement logic
        // do need the method signature to stay however to fulfill the 
        // interface 
        IEnumerator IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }

    }

}
