using System;

namespace Nullables {
    internal class Program {

        // variables that can or cannot have a value
        // created by putting a ? after the type 

        // Why use nullables? 
        // Good for when there are things that there might be no info for 
        // like a database where not all the values are filled in 

        static void Main(string[] args) {

            // this throws an error because you can't assign null to an integer
            //int? num1 = null;
            // if you tried to print this out like below it would throw an error
            //int num5; 


            // a nullable can have a value or not
            int? num1 = null; // will just be whitespace
            int? num2 = 1337; // 1337

            double? num3 = new Double?(); // whitespace
            double? num4 = 3.14159; // 3.14.159
            double? num5 = null; // whitespace

            bool? bval = null; // whitespace
            bool? bval2 = new bool?(); // whitespace

            // The null numbers are:  ,1337,,3.14159,  
            Console.WriteLine($"The null numbers are: {num1},{num2},{num3},{num4},{num5}");
            // The nullable bool value is ,
            Console.WriteLine($"The nullable bool value is {bval}, {bval2}");

            // basic example of why to use a nullable
            // could be used for a selection form, database etc as an example
            bool? isMale = null;

            if (isMale == true) {
                Console.WriteLine("User is male");
            } else if (isMale == false) {
                Console.WriteLine("User is female");
            } else {
                Console.WriteLine("No/other gender chosen");
            }

            // convert a nullable to a non-nullable type

            double? num6 = 13.1;
            double? num7 = null;
            double num8;

            if (num6 == null) {
                num8 = 0.0;
            } else {
                num8 = (double)num6;
            }

            Console.WriteLine($"Num 8 is {num8}"); // Num 8 is 13.1

            // faster way to do the above conversion 
            // null coalescing operator ??

            // if num6 is empty then enter 8.53 
            num8 = num6 ?? 8.53; // since num6 is not null its original value of 13.1 was used
            Console.WriteLine($"Num 8 is {num8}"); // Num 8 is 13.1

            num8 = num7 ?? 8.53; // since num7 is null 8.53 was assigned to it
            Console.WriteLine($"Num 8 is {num8}"); // Num 8 is 8.53

        }
    }
}
