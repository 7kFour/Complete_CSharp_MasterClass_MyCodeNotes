using System;

namespace NestedIFChallenge_Sec4 {
    internal class Program {
        // create a void method called NestedCheck
        // it has 1 integer parameter
        // if the argument passed is divisible by 3 print "Divisible by 3."
        // if the argument passed is NOT divisible by 3 but is divisible by 7 print "Divisible by 7."
        // if neither condition above is true but the number is odd print "Odd number."
        // otherwise print "Even number."

        static void Main(string[] args) {

            NestedCheck(26);
        }

        public static void NestedCheck(int x) {
            if (x % 3 == 0) {
                Console.WriteLine("Divisible by 3.");
            } else if (x % 3 == 1 && x % 7 == 0) {
                Console.WriteLine("Divisible by 7.");
            } else if (x % 2 == 1) {
                Console.WriteLine("Odd number.");
            } else {
                Console.WriteLine("Even number.");
            }
        }
    }
}
