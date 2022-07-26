using System;

namespace BreakAndContinuePractice {
    internal class Program {
        static void Main(string[] args) {
            // skip everything divisible by 3 
            // stop while loop when i = 10
            int i = -10;

            while (true) {

                // if i is 10 stop the while loop 
                // this is the exit condition
                if (i == 10) {
                    break;
                // if i mod 3 is not 0 then write i
                } else if (i % 3 != 0) {
                    Console.WriteLine(i++);  
                } else {
                    i++;
                }

            }

            // provided class solution
            int x = -10;

            while (true) {
                if (x % 3 == 0) {
                    x++;
                    continue;
                }
                if (x == 10)
                    break;
                Console.WriteLine(x++);
            }


        }

    }
}
