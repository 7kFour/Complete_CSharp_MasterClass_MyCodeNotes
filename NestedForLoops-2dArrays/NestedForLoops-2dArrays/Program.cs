using System;

namespace NestedForLoops_2dArrays {
    internal class Program {

        // this is currently static because we are using it inside our 
        // static main method 
        // see C# notebook for more explanation on what static keyword does 
        // for now - just know that you can't use non-static items inside of 
        // static methods
        static int[,] matrix = {
            {1,2,3}, // row 1 // 3 columns
            {4,5,6}, // row 2 // 3 columns
            {7,8,9}  // row 3 // columns 
        };

        static void Main(string[] args) {
            Console.WriteLine("This is the 2d array printed using foreach loop");
            foreach (int n in matrix) {
                Console.Write($"{n} ");
            }

            Console.WriteLine("\n\nThis is the 2d array printed using nested for loop");
            // outer for loop
            // GetLenght(0) will return the 0th dimension - in this case 
            // the number of rows (so 3) 
            for (int i = 0; i < matrix.GetLength(0); i++) {

                // inner for loop
                // to iterate through the colums of the rows 
                // we nest another for loop 
                // using GetLength(1) will look at how many columns there are
                // eg how many values in each subarray
                for (int j = 0; j < matrix.GetLength(1); j++) {

                    // printing diagonal values 
                    if (i == j) {
                        Console.Write(matrix[i, j] + " ");
                    } else {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}
