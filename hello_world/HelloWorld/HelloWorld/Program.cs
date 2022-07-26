using System;

namespace HelloWorld
{
    internal class Program
    {
        // entry point for program 
        static void Main(string[] args)
        {
            // declaring a variable without initializing it
            int num1;
            // initializing variable
            num1 = 13;
            Console.WriteLine(num1);

            // declare and initialize
            int num2 = 23;
            int sum = num1 + num2;
            Console.WriteLine(sum);
            
            // using concatenation
            // writeline is smart enough to allow this concatentation without needing to cast the ints to str
            Console.WriteLine("num1: " + num1 + " + num2: " + num2 + " is " + sum);

            // declare multiple variables at once
            int num3, num4, num5;

            // you can overwrite variables later in the code
            num2 = 50;
            Console.WriteLine("num2 is now: " + num2);

            // using some doubles 
            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;
            Console.WriteLine("d1/d2 is " + dDiv);

            // don't forget the f 
            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;
            Console.WriteLine("f1/f2 is " + fDiv);

            // even thought i divided a double by an int i still got a double
            // keep that in mind
            double dIDiv = d1 / num1;
            Console.WriteLine("d1 / num1 " +  dIDiv);

            // string example
            // using a S makes it the string class like Console so you could String.Methods
            string myName = "Anthony";
            Console.WriteLine(myName);
            // concatenation
            Console.WriteLine("My name is " + myName);
            // can concatenate in variable initialization also
            string message = "My name actually is " + myName;
            Console.WriteLine(message);

            // you can use string methods on a string variable
            // try message. and you will see String class methods pop up
            string capsMessage = message.ToUpper();
            Console.WriteLine(capsMessage);

            // lowercase message
            string lowerMessage = message.ToLower();
            Console.WriteLine(lowerMessage);

            Console.Write("Enter a string and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.Write("Enter a character and press enter - it will output as ASCII: ");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}:", asciiValue);

            //// change text color of console
            //Console.ForegroundColor = ConsoleColor.Red;
            //// change background color of console
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //// apply color changes to entire console area 
            //Console.Clear();

            Console.Read();
            
        }
    }
}
