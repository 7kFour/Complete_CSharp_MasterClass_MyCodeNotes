using System;

namespace MethodChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name? ");
            // taking user input and giving to method as argument
            GreetFriend(Console.ReadLine());

            // sec 3 coding ex 1 
            Console.WriteLine(LowUpper("hello"));
            Count("HeY ThErE !");

            Console.Read();
        }

        // writes to console the string message and interpolates
        // the name that the user enters to personalize the greeting
        public static void GreetFriend(string name)
        {
            Console.WriteLine($"Hello {name}, my friend!");
        }

        // method for sec 3 coding ex 1
        // take string as input - create upper and lowercase copies
        // return the result of the join 
        // ex "hello" will return "helloHello"
        public static string LowUpper(string theString)
        {
            string low = theString.ToLower();
            string up = theString.ToUpper();
            string lowUp = String.Concat(low, up);
            return lowUp;
        }

        // take a string as input - return nothing
        // print to console "The amount of letters is X" 
        // X should be replaced with the length of the string input
        // ex "hello" will print "The amount of letters is 5."
        public static void Count(string theString)
        {
            Console.WriteLine($"The amount of letters is {theString.Length}.");
        }
    }
}
