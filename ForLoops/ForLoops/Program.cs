using System;

namespace ForLoops {
    internal class Program {
        static void Main(string[] args) {
            for (int i = 0; i < 21; i ++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("start second loop");

            // another cool way to print out the odd numers
            for (int i = 1; i < 20; i+= 2) {
                Console.WriteLine(i);
            }


            Console.ReadKey();
        }
    }
}
