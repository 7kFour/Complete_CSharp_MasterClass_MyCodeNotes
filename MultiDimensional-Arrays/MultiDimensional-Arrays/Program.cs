using System;

namespace MultiDimensional_Arrays {
    internal class Program {
        static void Main(string[] args) {

            // dimensions of array are based on how many , are added

            // 2d array
            string[,] matrix;

            // 3d array
            int[,,] threeD;

            // 4d array
            bool[,,,] fourD;

            // etc... 

            // initialize 2d array
            // a 2d array is also called a matrix
            int[,] array2d = new int[,] {
                {1, 2, 3}, // row 0
                {4, 5, 6}, // row 1
                {7, 8, 9}, // row 2
            };

            // positions you want to access inside []
            Console.WriteLine(array2d[1,1]); // 5

            // initialize 3d array
            string[,,] array3d = new string[,,] { 
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"hi", "there"}
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"same", "error"}
                }
            };
            // access 3d array
            Console.WriteLine(array3d[1, 0, 1]); // "101"


            // another way to declare multidimension arrays
            // and initialize them at the same time 
            // [number of rows, number of entries per row]
            string[,] array2dString = new string[3, 2] {
                {"two", "entries"},
                {"in", "each"},
                {"sub", "list"}
             };

            // change "each" to "tractor"
            array2dString[1, 1] = "tractor";
            Console.WriteLine(array2dString[1,1]); // outputs "tractor"

            // if you don't know the number of dimensions that an array has
            int dimensions = array2dString.Rank;
            Console.WriteLine(dimensions);
        }

        // creating a dynamic (variable size) array
        int[,] array2d2 = { { 1, 2 }, { 3, 4}, { 5, 6 } };
    }
}
