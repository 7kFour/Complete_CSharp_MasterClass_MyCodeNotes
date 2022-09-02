using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Demo_1 {
    internal class Program {
        static void Main(string[] args) {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // this would work with an XML or DataTable instead of an Array also
            OddNumbers(numbers);
        }

        static void OddNumbers(int[] n) {
            // check each number in the argument array and selects numbers that have a remainder
            // when modulo divided by 2
            // from is basically a foreach loop - where is a filter and selection is a projection operator
            IEnumerable<int> oddNumbers = from number in n where number % 2 != 0 select number;

            // can use foreach on an IEnumerable<T>
            Console.Write("Odd Numbers: ");
            foreach (int num in oddNumbers) {
                Console.Write($"{num} ");
            }
        }
    }
}
