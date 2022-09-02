using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_to_ObjectsAndQuery_Operators {
    internal class Program {

        // Collection of LINQ query operators 
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/standard-query-operators-overview

        static void Main(string[] args) {

            // create university manager object
            UniversityManager um = new UniversityManager();

            // take user input for uni id
            //Console.Write("Please enter a University Id: ");
            //int universityId = 0;

            //if (int.TryParse(Console.ReadLine(), out universityId)) {
            //    um.UserStudentSearch(universityId);
            //    Console.WriteLine();
            //} else {
            //    Console.WriteLine("Please enter a valid University Id.");
            //    Console.WriteLine();
            //}

            // another way to sort
            int[] someInts = { 30, 12, 4, 3, 12, 103, 94, 8, 26 };
            // ints will be ordere smallest to largest, 3,4,12...
            IEnumerable<int> sortedInts = from i in someInts orderby i select i;
            // ints will be reversed 
            IEnumerable<int> reveresedInts = sortedInts.Reverse();

            // print ordered list
            Console.Write("Ordered List: ");
            foreach (int i in sortedInts) {
                Console.Write($" {i}");
            }
            Console.WriteLine("\n");

            // print reversed list
            Console.Write("Reversed List with IEnumerable<T>.Reverse<T>(): ");
            foreach (int i in reveresedInts) {
                Console.Write($" {i}");
            }
            Console.WriteLine("\n");

            // another way to reverse sorted
            // to just print this sorted instead of reversed changed `descending` to `ascending`
            IEnumerable<int> reversedSortedInts = from i in someInts orderby i descending select i;
            Console.Write("Reversed Sorted List with LINQ: ");
            foreach (int i in reversedSortedInts) {
                Console.Write($" {i}");
            }
            Console.WriteLine("\n");


            um.MaleStudents();
            Console.WriteLine();

            um.FemaleStudents();
            Console.WriteLine();

            um.SortStudentsByAge();
            Console.WriteLine();

            um.AllStudentsFromStanford();
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
