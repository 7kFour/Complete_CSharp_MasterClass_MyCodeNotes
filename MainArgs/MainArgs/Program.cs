﻿using System;

namespace MainArgs {
    internal class Program {

        // string[] args 
        // an array of strings called args 
        // an object passed to the main method when the application gets started
        // useful for taking information from the application user without stopping the application
        // or taking information from another applicaton

        // right click on application in solution explorer > properties > debug you can access your 
        // args there

        // navigate to your projects folder \projectName\projectName\bin\Debug\.netVersion
        // then run your project .exe 
        // .\projectName.exe <your argument here> so .\projectName.exe Anthony will output Hello Anthony
        // on linux/mac its ./project.Name with no .exe unless you're using mono

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
