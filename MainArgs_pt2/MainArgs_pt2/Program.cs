using System;
using System.ComponentModel;

namespace MainArgs {
    internal class Program {

        // see MainArgs for more detailed notes from Pt1
        
        // instead of using a prompt and Console.ReadLine() we will take all the information
        // our program needs from the user via command line arguments

        // rule of thumb - never trust the user to not make mistakes - it is the developers job to 
        // try and account for mistakes that the user could make

        static void Main(string[] args) {

            // args array cannot be null. It's safe to acces the Length property without null checking
            // check the length of the array - if it's zero it no arguments were provided to the application
            if (args.Length == 0) {
                Console.WriteLine("This is a smart app that uses args ;), please provide arguments next time.\n" +
                    "Pass Help if you want more details.");

                // pause app to keep it from closing immediately
                Console.ReadKey();

                // quit application since args are empty and we can't proceed forward
                return;
            }

            // store arg[0] to Lower it later and check if user entered help/Help 
            string storeArg0 = args[0];

            // check if first command arg entered is help 
            // using ToLower() to standarize input 
            if (storeArg0.ToLower() == "help" || storeArg0.ToLower() == "-h") {

                // display manual for user 
                Console.WriteLine("**********************\n* Instructions:");
                Console.WriteLine("* Use one of the below commands followed by 2 numbers:");
                Console.WriteLine("* 'add' : to add 2 numbers");
                Console.WriteLine("* 'subtract' : to subtract 2 numbers");
                Console.WriteLine("* Example - add 2 5");
                Console.WriteLine("**********************");

                // pause so that program doesn't close instantly
                Console.ReadKey();
                // quit the app
                return;
            } 

            // our program expects 3 arguments - so we need to check for that
            if (args.Length != 3) {
                Console.WriteLine("Invalid arguments, please use the Help command or -h for instructions");

                // pause so that program doesn't close instantly
                Console.ReadKey();
                // quit the app
                return;
            }

            // in C# 6 and earlier, you must declare a variable in a separate statement before you pass it 
            // as an out argument because if the parsing operation fails the variable passed as out will have
            // its default value if it was a value type, or null if it's a reference type
            // its more logical to declare and pass the variable in the same line 

            // trying to parse the user input to make sure they are able to be parsed to floats
            bool isNum1Parsed = float.TryParse(args[1], out float num1);
            bool isNum2Parsed = float.TryParse(args[2], out float num2);

            // error message if the user entered invalid numbers
            if (!isNum1Parsed || !isNum2Parsed) {
                Console.WriteLine("Invalid arguments, please use the Help command or -h for instructions");

                // pause so that program doesn't close instantly
                Console.ReadKey();
                // quit the app
                return;
            }

            // storing result of addition/subtraction 
            float result;

            // reusing storeArg0 to Lower and make checking input easier 
            // instead of just switch (args[0]) {} like he did
            // switch checks for add/subtract
            switch (storeArg0.ToLower()) {
                case "add":
                    result = num1 + num2;
                    Console.WriteLine($"The sum of {num1} and {num2} is {result}.");
                    break;

                case "subtract":
                    result = num1 - num2;
                    Console.WriteLine($"The difference of {num1} and {num2} is {result}.");
                    break;

                default:
                    Console.WriteLine("Invalid arguments, please use the Help command or -h for instructions");
                    break;
            }
        }
    }
}
