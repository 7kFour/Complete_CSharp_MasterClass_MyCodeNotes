using System;
using System.Collections;

namespace Hashtables___Challenge {

    // Challenge: 

    /* Write a program that will iterate through each element of the students array
     * and insert them into a hashtable.
     * If a student with the same ID already exists in the hashtable skip it and display
     * the following error:
     * "Sorry, a student with the same ID already exists."
     * Hint: Use the method ContainsKey() to check if a student with the same ID 
     * already exists
     */

    internal class Program {
        static void Main(string[] args) {

            // create and initialize array of students 
            Student[] students = new Student[5] {
                new Student(1, "Dennis", 88),
                new Student(2, "Olaf", 97),
                new Student(6, "Ragnar", 65),
                new Student(1, "Rachel", 73),
                new Student(4, "Janelle", 58)
            };

            // create new hashtable and initialize with empty hashtable object 
            Hashtable studentsTable = new Hashtable();

            // iterate with students array
            // check if id value is already a key
            // if it is - print error
            // else add student as value and student id as key
            foreach (Student s in students) {
                if (studentsTable.ContainsKey(s.Id)) {
                    Console.WriteLine($"Sorry, a student with the same ID: {s.Id} already exists.");
                } else {
                    studentsTable.Add(s.Id, s);
                    Console.WriteLine($"Student with ID: {s.Id} was added.");
                }
            }

            // for styling
            Console.WriteLine();

            // write each students id, name, and gpa to console
            foreach (Student student in studentsTable.Values) {
                Console.WriteLine($"ID: {student.Id}\nName: {student.Name}\nGPA: {student.GPA}\n");
            }
        }
    }

    class Student {

        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float gpa) {
            this.Id = id;
            this.Name = name;
            this.GPA = gpa;
        }
    }
}
