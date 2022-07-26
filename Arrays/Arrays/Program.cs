using System;

namespace Arrays {
    internal class Program {
        static void Main(string[] args) {

            // the new keyword is used to create or instantiate an object

            // create an array of size 5
            int[] grades = new int[5];

            // adding values to the array
            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 16;
            grades[3] = 9;
            grades[4] = 12;

            // getting a value from the array 
            Console.WriteLine($"Grade at index 0: {grades[0]}");

            // can change values in the array 
            // taking user input

            string input = Console.ReadLine();

            // converting input string to int
            // would be safer to use tryparse 
            // but it's ok right now because we know we will enter whole numbers only
            // changing grade of 0 to user input value instead of 20
            grades[0] = int.Parse(input);

            // another way to create and initialize an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            // third way to initialize
            int[] gradesOfMathStudentsB = new int[] { 15, 20, 3, 17, 18, 5 };

            // one way of getting the length of an array - best way
            Console.WriteLine($"Length of grades - class a: {gradesOfMathStudentsA.Length}");
        }
    }
}
