using System;

namespace ArraysAsParamsChall {
    internal class Program {
        static void Main(string[] args) {
            // Chall - create array of happiness in main method
            // assign 5 values to it
            int[] happiness = { 7, 14, 21, 23, 31 };

            // call method you created in main method - use happiness array as the argument
            // create a foreach loop in the main method to write all values onto the console
            foreach (int i in ArrayPlusTwo(happiness)) {
                Console.WriteLine(i);
            }
        }

        // create a method which has an array of type int as its parameter
        // method should increase the argument given by 2 for each entry
        static int[] ArrayPlusTwo(int[] happy) {

            for (int i = 0; i < happy.Length; i++) {
                happy[i] += 2;
            }

            return happy;
        }
    }
}
