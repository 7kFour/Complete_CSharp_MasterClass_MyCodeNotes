using System;

namespace ConversionStringsVariables
{
    // constants are immutable values which are known at compile time
    // and do not change their value for the life of the program
    internal class Program
    {
        // constants as fields
        // things that will never change like number of weeks in a year are
        // good things to make into constants
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;

        // create a constant of type string with your birthday as its value
        const string myBDay = "11-21-1985";


        static void Main(string[] args)
        {

            // implicit conversion 
            // basically assigning a smaller type to a bigger type 
            // like int to long or float to double 
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            // cast double to int; 
            // this is explicit conversion
            double myDouble = 13.37;
            int myInt;

            myInt = (int)myDouble;
            Console.WriteLine(myInt);

            // type conversion 
            // for instance changing an int to a string 
            string myString = myDouble.ToString(); // will become "13.37"
            Console.WriteLine(myDouble);

            string typeChange = myFloat.ToString();
            Console.WriteLine(num.ToString() + " -- " + typeChange);

            // can change bool to string also 
            bool sunIsShining = false; // becomes "false"
            string myBoolString = sunIsShining.ToString();
            Console.WriteLine(myBoolString);

            // we need to parse these to numbers if we want to actually add them 
            string my1stString = "15";
            string my2ndString = "13";
            string result = my1stString + my2ndString; // this would be "1513"
            Console.WriteLine(result);

            // to make an int from a string 
            int num1 = Int32.Parse(my1stString);
            int num2 = Int32.Parse(my2ndString);
            Console.WriteLine(num1 + num2); // 28

            // assignment 1 - Exercise Parsing
            string stringForFloat = "0.85";
            string stringForInt = "12345";
            Console.WriteLine(float.Parse(stringForFloat) + "\n" + int.Parse(stringForInt));

            // define variables for string lesson
            int age = 36;
            string name = "Anthony";

            // 1. string concatentation 
            // works fine with ints and strings you don't need to cast 
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + ", I am " + age + " years old.");

            // 2. String formatting
            // uses index 0, 1, 2 etc for your variables 
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0}, I am {1} years old.", name, age);

            // 3. String interpolation
            // string interpolation uses % at the start - allows us to write variables like {variableName}
            Console.WriteLine("String Interpolation");
            // can put variables at the end but it is not necessary
            Console.WriteLine($"Hello my name is {name}, I am {age} years old.", name, age);
            // this way without the variables attached to the end also works and is better
            Console.WriteLine($"Hello my name is {name}, I am {age} years old. No variables.");

            // 4. verbatim strings
            // verbatim strings start with @ - tell compilter to take string literally
            // ignores spaces and escape characters like \n 
            Console.WriteLine("Verbatim Strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet, \n plus a bunch of other characters
                                        keeps      in    white space   too");

            // verbatim strings can be very useful in certain situations
            // useful for filepaths 
            Console.WriteLine(@"C:\User\Admin\Dog Pictures\Dog1\Super CoolDog.png");

            // printing out birthday constant
            Console.WriteLine($"My birthday is always going to be {myBDay}");


            Console.ReadKey();
        }
    }
}
