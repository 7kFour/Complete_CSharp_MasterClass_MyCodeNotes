using System;
using System.Reflection.Metadata;

namespace FunctionsAndMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("I am an argument and am called from a method");

            // you can save the return value of a method as a variable also
            int a = Add(3, 5);
            Console.WriteLine(a);
            // you can use a method as an argument
            Console.WriteLine(Add(13, 28));
            // another example of using a method as an argument
            // a method that returns something is equal to the return value itself 
            // so the below is saying Add(10, 30); and that add is actually equal to the values
            // of the arguments so 40
            Console.WriteLine(Add(Add(5, 5), Add(10, 20)));

            Console.WriteLine(Multiply(25, 50));
            Console.WriteLine(Divide(13354, 73));
            
            Console.Read();
        }
        
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }
        
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
