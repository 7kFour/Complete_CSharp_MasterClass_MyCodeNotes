using System;
using System.Collections.Generic;

namespace IEnumerableDemo3 {

    // in OOP / Inheritance a Child of a Parent can be passed as an argument
    // to a method the same as the Parent would be
    // passing an IEnumerable<T> to a method - is similar - in that we can 
    // pass collections that implement the IEnumerable<T> interface


    internal class Program {
        static void Main(string[] args) {

            // a list of type List<int> initialized with some ints 
            List<int> numberList = new List<int>() { 8, 6, 2 };

            // array of type int[] intialized with some ints
            int[] numArr = new int[] { 1, 7, 1, 3 };

            CollectionSum(numberList);
            CollectionSum(numArr);
        }

        static void CollectionSum(IEnumerable<int> anyCollection) {

            // sum variable to store sum of ints in anyCollection
            int sum = 0;

            // for each number in the collection add its value to sum
            foreach (int n in anyCollection) {
                sum += n;
            }

            // print the sum
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
