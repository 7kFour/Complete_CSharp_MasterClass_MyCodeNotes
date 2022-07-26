using System;

namespace BreakAndContinue {
    internal class Program {
        static void Main(string[] args) {
            for (int i = 0; i < 10; i++) {
                if (i == 3) {
                    Console.WriteLine("we skip number 3 ");
                    // continue will skip this iteration of the loop
                    continue;
                }
                // notice we need to write after the continue otherwise 
                // it would write 'we skip number' inbetween 3 and 4
                Console.WriteLine(i);
            }
            
            Console.Read();
        }
    }
}
