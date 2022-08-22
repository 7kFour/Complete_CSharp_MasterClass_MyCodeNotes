using System;

namespace MainArgs {
    internal class Program {

        // see MainArgs for more detailed notes from Pt1

        static void Main(string[] args) {

            // args array cannot be null. It's safe to acces the Length property without null checking
            // check the length of the array - if it's zero it no arguments were provided to the application
            if (args.Length == 0) {
                Console.WriteLine("This is a smart app that uses args ;), please provide arguments next time");

                // pause app to keep it from closing immediately
                Console.ReadKey();

                // quit application since args are empty and we can't proceed forward
                return;
            }

            Console.WriteLine($"Hello {args[0]}!");

            Console.ReadKey();
        }
    }
}
