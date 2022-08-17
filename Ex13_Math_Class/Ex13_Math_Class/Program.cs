using System;

namespace Ex13_Math_Class {
    internal class Program {
        static void Main(string[] args) {
            Run("12");
        }

        public static double ConvertToRadians(double angle) {
            return (Math.PI / 180) * angle;
        }

        public static void Run(string line) {
            // try parse string and output to n
            int n;
            bool success = int.TryParse(line, out n);

            // convert int to radian value and make double
            double radN = ConvertToRadians(n);

            // if int was parsed and is between 0-180 
            // calculate Sine, Cosine and Tanger
            // else - Check the Input
            if (success && n >= 0 && n <= 180) {
                Console.WriteLine($"Cos = {Math.Cos(radN)}");
                Console.WriteLine($"Sine = {Math.Sin(radN)}");
                Console.WriteLine($"Tg = {Math.Tan(radN)}");
            } else {
                Console.WriteLine("Check the input!");
            }
        }
    }
}
