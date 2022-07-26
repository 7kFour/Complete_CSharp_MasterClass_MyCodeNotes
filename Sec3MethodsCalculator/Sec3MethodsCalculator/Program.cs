using System;

namespace Sec3MethodsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter first int to add: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter second int to add: ");
            string input2 = Console.ReadLine();

            int sum = Add(int.Parse(input1), int.Parse(input2));   
            Console.WriteLine($"{input1} + {input2} = {sum}");
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
    }
}

