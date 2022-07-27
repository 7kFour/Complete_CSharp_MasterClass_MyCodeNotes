using System;
using System.Collections;

namespace Hashtables {
    internal class Program {

        // Hashtables have a Key:Value pair 
        // Key and Value don't need to be of the same type (they do in a dictionary)
        // Keys do not all need to be of the same type either 
        // Key: could be type int - Value: could be type object <-- example

        // DictionaryEntry Struct
        // when adding a new entry (k:v pair) to a HT
        // a new DictionaryEntry object will be created an inserted into HT
        // meaning a HT is a basically a collection of DictionaryEntry(ies)
        
        // can iterate through a HT using a temporary object of type DictionaryEntry
        // with a foreach loop
        // see Ln 62

        static void Main(string[] args) {

            // need to add using System.Collections

            // create a new hashtable and initialize it with an empty hashtable object
            Hashtable studentsTable = new Hashtable();

            // creating instances of student to add to our HT
            Student s1 = new Student(1, "Maria", 98);
            Student s2 = new Student(2, "Jason", 76);
            Student s3 = new Student(3, "Clara", 43);
            Student s4 = new Student(4, "Steve", 55);

            // adding students to Hashtable 
            // using the unique ID as the key 
            // using all the information in the student object as the value 
            studentsTable.Add(s1.Id, s1);
            studentsTable.Add(s2.Id, s2);
            studentsTable.Add(s3.Id, s3);
            studentsTable.Add(s4.Id, s4);

            // the value in a HT will be stored as type obj 
            // can't assigned an obj type to type Student
            // has to be type Student
            // this won't work
            //Student storedStudent1 = studentsTable[1];

            // need to cast to Student
            // retrieving the value at Key: 1
            //Student storedStudent1 = (Student)studentsTable[1]; // retrieve individual item with known id

            // can retrieve value at Key this way as well if 
            // you aren't sure what the value behind the key is

            Student storedStudent1 = (Student)studentsTable[s1.Id]; // retrieve individual item with known id

            // output will be
            // Student ID: 1
            // Name: Maria
            // GPA: 98
            Console.WriteLine($"Student ID: {storedStudent1.Id}\nName: {storedStudent1.Name}" +
                $"\nGPA: {storedStudent1.GPA}");

            // print all data in a HT without a particular key 
            // could just say 'entry' if you didn't know what the table 
            //had in it
            // retrieve all values from HT
            foreach (DictionaryEntry s in studentsTable) {

                // need to use a temp value to cast to Student 
                // otherwise s.Value would be an obj type and we couldn't use it
                // couldn't acces ID or anything
                Student tempValue = (Student)s.Value;

                // once casted to proper type can write values to console
                // just using another method to print instead of $""
                // using multiple CW() for illustration purposes 
                Console.WriteLine("Student ID: {0}", tempValue.Id);
                Console.WriteLine("Student Name: {0}", tempValue.Name);
                Console.WriteLine("Student GPA: {0}", tempValue.GPA);
            }

            // the above foreach loop is meant to illustrate that a HT is 
            // really just a collection of DictionaryEntry

            // foreach loop can be simplified by pulling the values directly 
            // going through the values directly with the 
            foreach (Student s in studentsTable.Values) {
                Console.WriteLine("Student ID: {0}", s.Id);
                Console.WriteLine("Student Name: {0}", s.Name);
                Console.WriteLine("Student GPA: {0}", s.GPA);
            }

            // foreach output will be 
            // Student ID: 4
            // Name: Steve
            // GPA: 55
            // Student ID: 3
            // Name: Clara
            // GPA: 43
            // etc... 
            // both foreach loop starts with Steve and works to Maria

        }
    }

    // creating class in Program.cs for readability 
    // best practice to create class in it's own file

    class Student {

        // property called Id
        // used like a unique identifier
        public int Id { get; set; }

        // property called Name
        public string Name { get; set; }

        // property called GPA
        public float GPA { get; set; }

        // simple consructor to assign values 
        public Student(int id, string name, float GPA) { 
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }

}
