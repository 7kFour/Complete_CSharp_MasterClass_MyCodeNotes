using System;

namespace JaggedArrays {
    internal class Program {
        static void Main(string[] args) {

            // declare jagged array
            int[][] jaggedArray = new int[3][];

            // add arrays to jagged array
            // at position zero we now have array of size 5
            // these are all empty
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            // initializing - adding values to arrays
            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 43, 19, 57 };
            jaggedArray[2] = new int[] { 16, 22 };

            // alternative to above 3 step method
            // we can create and initalize jagged array immediately 
            // you must still declare what type you want in each array
            int[][] jaggedArray2 = new int[][] {
                new int[] { 2, 3, 5, 7, 11 },
                new int[] { 43, 19, 57 }
            };

            // accessing a value from a jagged array 
            Console.WriteLine($"jaggedArray 2 middle value of first array {jaggedArray2[0][2]}"); // 5

            // mini challenge 
            // get all values from jaggedArray 1 and 2 onto the console 
            // x represents the sub arrays you must use whatever variable you use
            // in the first foreach as the container in the nested foreach
            Console.WriteLine("\njaggedArray values:\n");
            foreach (int[] x in jaggedArray) {
                foreach (int value in x) {
                    Console.WriteLine(value);
                }
            }

            Console.WriteLine("\njaggedArray2 values:\n");

            // using regular nested for loops for jaggedArray2
            for (int i = 0; i < jaggedArray2.Length; i++) {
                for (int j = 0; j < jaggedArray2[i].Length; j++) {
                    Console.WriteLine($"Element at position {i}{j} value: {jaggedArray2[i][j]}");
                }
            }
        }
    }
}
