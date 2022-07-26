using System;

namespace ForEachLoops {
    internal class Program {
        static void Main(string[] args) {
            
            int[] nums = new int[10];

            // i < length of the array we are iterating through
            // can also just array.Length
            for (int i = 0; i < 10; i++) {
                
                // basically at index 0 the value will be 0 
                // index 1 value will be 1 etc
                nums[i] = i;
            }

            // iterating through the array to get the value 
            // that we set in the loop above
            // showing that we can use .Length instead of < size of array 
            // this is safer - wont go out of bonds of array this way
            for (int j = 0; j < nums.Length; j++) {
                Console.WriteLine($"Element{j} - {nums[j]} ");
            }

            // another safe method is the foreach loop 
            // this basically creates a variable (int k) 
            // then goes through the array storing the value at 
            // each index in k
            // k is actually the value of the nums at a specific index
            // just using a counter since we are displaying Elements{the counter value}
            int counter = 0;
            foreach (int k in nums) {
                Console.WriteLine($"Element{counter} - {nums[k]} ");
                counter++;
            }

            // create an array of 5 people
            // create a foreach loop that greets them by name 
            string[] peeps = { "Shin", "Ber", "Erik", "Elizabeth", "Sid" };

            foreach (string n in peeps) {
                Console.WriteLine($"Hello {n}");
            }

        }
    }
}
