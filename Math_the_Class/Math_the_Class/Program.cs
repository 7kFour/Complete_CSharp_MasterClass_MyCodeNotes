using System;

namespace Math_the_Class {
    internal class Program {
        static void Main(string[] args) {

            // Math has many mathematical functions built in -- just enter Math. to see many
            // https://docs.microsoft.com/en-us/dotnet/api/system.math?view=net-6.0

            // few examples - mess around with the Class to see what else it can do
            // if you're working with math remember this Class it can save a lot of time

            // forced rounding up - ceiling - get next whole number up
            Console.WriteLine("Ceiling: " + Math.Ceiling(15.3)); // 16 

            // forced round down - floor - get next whole number down
            Console.WriteLine("Ceiling: " + Math.Ceiling(15.7)); // 15

            int num1 = 13;
            int num2 = 9;

            // get lower of 2 values
            Console.WriteLine($"Lower of {num1} and {num2} is {Math.Min(num1, num2)}"); // Lower of 13 and 9 is 9

            // get higher of 2 values
            Console.WriteLine($"Higher of {num1} and {num2} is {Math.Max(num1, num2)}"); // Higher of 13 and 9 is 13

            // Power
            Console.WriteLine($"3 to the power of 5 is {Math.Pow(3, 5)}"); // 3 to the power of 5 is 243

            // Math has the constants Pi and E (natural logarithmic base)
            // only a specific precision for Pi and E - what fits in a double
            Console.WriteLine($"Pi: {Math.PI}"); // Pi: 3.141592653589793
            Console.WriteLine($"E: {Math.E}"); // E: 2.718281828459045

            // square root 
            Console.WriteLine($"Square root of 25 is {Math.Sqrt(25)}"); // Square root of 25 is 5

            // Absolute number - always positive 
            Console.WriteLine($"-25 as an absolute is {Math.Abs(-25)}"); // -25 as an absolute is 25

            // Cosine
            Console.WriteLine($"Cosine of 1 is {Math.Cos(1)}"); // Cosine of 1 is 0.5403023058681398

            Console.ReadLine();
        }
    }
}
