using System;

namespace Ex14_Delegates {
    internal class Program {

        // Create public delegate called OperationDelegate
        // takes 2 arguments of float type and returns a float type

        // Create 4 static public methods called Add, Subtract, Multiple, and Divide
        // each takes 2 arguments of float type and returns a float type value 
        // corresponding to the result of the performed operation
        // eg Add(float x, float y) { return x+y }

        // Create method ApplyOperation that takes 2 float arguments and one delegate 
        // and applies the operation to those values 

        public delegate float OperationDelegate(float numOne, float numTwo);
        static void Main(string[] args) {

            // creating variables for readability when printing
            float a = ApplyOperation(15, 20, Add);
            float s = ApplyOperation(100, 80, Subtract);
            float m = ApplyOperation(5, 10, Multiply);
            float d = ApplyOperation(40, 2, Divide);

            Console.WriteLine($"15 + 20 = {a}\n100 - 80 = {s}" +
                $"\n5 * 10 = {m}\n40 / 2 = {d}");
            
        }

        public static float ApplyOperation(float x, float y, OperationDelegate o) {
            return o(x, y);
        }

        public static float Add(float x, float y) {
            return x + y;
        }

        public static float Subtract(float x, float y) {
            return x - y;
        }
        public static float Multiply(float x, float y) {
            return x * y;
        }
        public static float Divide(float x, float y) {
            return x / y;
        }
    }
}
