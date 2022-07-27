using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionaries {

    // a dictionary is a generic collection
    // it is a collection of key value pairs 
    // which is a struct that is defined like a key:value pair
    // example of how the struct would look KeyValuePair < TKey, TValue >
    // can see an example on ln 93
    // key:value type must be defined when creating a dictionary
    // uses System.Collections.Generic

    internal class Program {
        static void Main(string[] args) {

            // as a side note - 
            // it wouldn't be a good practice to use something like the Role/Job title
            // as a key in most cases because there could be more than one person with
            // the same title/role 
            // in a situation like that you would probably want to use something like
            // employee id number 
            // the example of Role was to show that you a lot of flexibility in types
            // of keys - so it doesn't just have to be an int for instance 
            
            // creating an array of type Employee to use as a 'database'
            Employee[] employees = {
                new Employee("CEO", "Gwyn", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Laura", 32, 21),
                new Employee("Secretary", "Petra", 28, 18),
                new Employee("Lead Developer", "Artorias", 55, 35),
                new Employee("Intern", "Ernst", 22, 8),
            };

            // declaring a dictionary 
            // initializing dictionary with empty dictionary object 
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            // declaring and initializing with values 
            Dictionary<int, string> myOtherDictionary = new Dictionary<int, string>() {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
            };

            // an example of creating a dictionary with info from a database
            // dictionary to use with our 'database' 
            // key will be a string 
            // each key's value will an entire Employee object
            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            // Key == employees role 
            // Value == entire employee object 
            // add employees from 'database' array to dictionary 
            // this is assuming that for every role there is only one employee
            // the Keys in a dictionary (and a hashtable) must be unique 
            foreach (Employee emp in employees) {
                // emp is the entire Employee object and has access to all
                // of an Employee types members
                employeesDirectory.Add(emp.Role, emp);
            }


            // updating values in a dictionary 
            // the new value you assign still has to be of the same type 
            // that the Dictionary was assigned with <string, Employee> for this example
            // ex - we want to update the value stored at a specific key
            string keyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(keyToUpdate)) {

                // replacing the Employee stored at "HR" with a new Employee
                // for instance Laura quit and Eleka was hired 
                employeesDirectory[keyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine($"Employee with Role/Key {keyToUpdate} was updated!");
            } else {
                Console.WriteLine($"No employee found with the key {keyToUpdate}.");
            }

            // remove values from a dictionary 
            // Remove() returns a bool - true if it removed something - false if not
            // this saves a step in writing the logic for it since you don't need
            // to check .ContainsKey() first 
            string keyToRemove = "Intern";
            if (employeesDirectory.Remove(keyToRemove)) {
                // now there is no intern in the dictionary
                Console.WriteLine($"Employ with Role {keyToRemove} was removed!");
            } else {
                Console.WriteLine($"No employee found with the key {keyToRemove}.");
            }

            // if you try and access a key that doesn't exist 
            // a KeyNotFoundException will be raised 
            // can wrap everything in conditional logic to check first
            // key variable below could be taken from user input a collection etc
            // hardcoded below as an easy example
            string key = "CEO";

            if(employeesDirectory.ContainsKey(key)) {

                // fetch data from a dictionary 
                // fetch data for the CEO specifically 
                // creating an Employee object and initializing it with the 
                // value for the key "CEO" from the dictionary
                Employee empl = employeesDirectory[key];
                Console.WriteLine($"Employee Name: {empl.Name}\nRole: {empl.Role}\nSalary: {empl.Salary}");
            } else {
                Console.WriteLine("This key doesn't exist.");
            }

            // can also use TryGetValue() to do something similar to the above if else
            // using TryGetValue() returns true if the operation was successful 
            // otherwise returns false
            // if it returns true below it will also send the value retrieved from the 
            // key "Intern" to the result variable 
            Employee result = null;
            if (employeesDirectory.TryGetValue("Intern", out result)) {
                Console.WriteLine("Value retrieved!");

                Console.WriteLine($"Employee Name: {result.Name}\nEmployee Role: {result.Role}" +
                    $"\nEmployee Age: {result.Age}\nEmployee Salary: {result.Salary}");
            } else {
                Console.WriteLine("The key does not exist!");
            }
            

            // retrieving an element of our dictionary with ElementAt() method
            // ElementAt() uses System.Linq namespace 
            // ElementAt() works because each key also has an internally assigned
            // integer value assigned to it -- similar to an index in an array
            for (int i = 0; i < employeesDirectory.Count; i++) {
                // using ElementAt(i) to return the key-value pair stored at index i
                KeyValuePair<string, Employee> keyValuePairExample = employeesDirectory.ElementAt(i);

                // print the key -- see what index position that key is assigned to
                Console.WriteLine($"Key: {keyValuePairExample.Key}, i is at position {i}");

                // store the value in an employee object 
                Employee employeeValue = keyValuePairExample.Value;

                // print properties of employee object 
                Console.WriteLine($"Employee Name: {employeeValue.Name}\nEmployee Role: {employeeValue.Role}" +
                    $"\nEmployee Age: {employeeValue.Age}\nEmployee Salary: {employeeValue.Salary}");
            }



        }
    }
}
