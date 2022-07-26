using System;
using System.Collections.Generic;

namespace lists {
    internal class Program {
        static void Main(string[] args) {

            // Lists can grow and shrink dynamically 

            // a collection (like a List) is a class and requires
            // an instance of the class before adding elements 
            // to the collection - hence the new List 
            // ^-- this also applies to other times when we use new like with Arrays

            // for collections containing only one data type must add
            // using System.Collections.Generic namespace 


            // declare List of type int with no values 
            var numbers = new List<int>();

            // declare and initialize a List of type int
            var moreNums = new List<int> { 1, 5, 35, 100 };

            // can type your List at declaration/initialization 
            // instead of using var 
            List<string> theStrings = new List<string>();

            // Add and Remove values from a List 
            var aRList = new List<int>();

            // Add integer with value of 7 to List 
            // further values are added to the end of the List
            aRList.Add(7); 
            aRList.Add(8);
            aRList.Add(9);
            aRList.Add(10);
            aRList.Add(11);

            // Remove element with value of 7 from List
            // removes by specified value 
            aRList.Remove(7);

            // remove a value from a List at a specified index 
            int index = 0;
            // will remove the value at index 0
            aRList.RemoveAt(index);
            // can also specify index without creating a variable first
            aRList.RemoveAt(0);

            // if you try to remove from an index and there is nothing at the index
            // you will get an out of bounds exception 

            // Get a value from a List 
            var valList = new List<int> { 25, 31 };
            int value = valList[0]; // value now == 25

            // Clearing a list - removing all values 
            var cList = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40 };
            cList.Clear();

            var loopList = new List<int> { 5, 10, 15, 20, 25, 30, 35, 40 };

            // Writing values from a List to the console
            // could add other logic 

            foreach (int n in loopList) {
                Console.WriteLine($"foreach loop: {n}");
            }

            // same as above 
            for (int i = 0; i < loopList.Count; i++) {
                Console.WriteLine($"for loop: {loopList[i]}");
            }

            // Simple example 
            // adding list returned from method to variable 
            List<int> theEvenNums = new List<int>(EvenInts());

            foreach (int n in theEvenNums) {
                Console.Write($"{n} ");
            }
        }

        // return List of type int 
        // List contains even ints between 100-170 inclusive
        public static List<int> EvenInts() {
            List<int> ints = new List<int>();

            for (int i = 100; i < 171; i++) {
                if (i % 2 == 0) {
                    ints.Add(i);
                }
            }

            return ints;
        }
    }
}
