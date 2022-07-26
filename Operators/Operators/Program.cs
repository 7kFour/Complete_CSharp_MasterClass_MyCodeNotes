using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 3, num3;

            // unary operators 

            // multiplies num1 by -1 so it will be -5 
            // if num1 was -5 it would become 5 
            num3 = -num1;
            Console.WriteLine($"num3 is {num3}");

            bool isSunny = true;
            // the ! negates the variable - the output will be False
            Console.WriteLine($"Is it sunny? {!isSunny}");

            // increment operator
            // post increment
            int num = 0;
            num++; // num becomes 1
            // remember that ++ after the variable will read the variable and then increment it
            Console.WriteLine($"num is {num}"); // num is still 1
            Console.WriteLine($"num is {num++}"); // num is still 1 but gets incremented to 2 after being displayed
            Console.WriteLine($"num is {num}"); // num is now displayed as 2

            // pre increment
            // if you want it to be incremented before being read
            Console.WriteLine($"num is {++num}"); // num is incremented then printed so it is 3 immediately

            // pre and post decrement 
            num--;
            Console.WriteLine($"num is {--num}");

            int result = num1 + num2;
            Console.WriteLine($"result of num1 + num2 is {result}");

            result = num1 - num2;
            Console.WriteLine($"result of num1 - num2 is {result}");

            result = num1 * num2;
            Console.WriteLine($"result of num1 * num2 is {result}");

            // dividing with ints doesn't round up or down 
            // it just cuts off anything after the decimal point
            // so 1.34 would be 1 and 1.68 would be 1
            result = num1 / num2;
            Console.WriteLine($"result of num1 / num2 is {result}");

            // modulo operator
            // divides and returns the remainder of the division
            result = num1 % num2;
            Console.WriteLine($"result of num1 % num2 is {result}");

            // relational and type operators

            // this will check if num1 is < num2 
            // if it is it will return true else it will return false
            bool isLower = num1 < num2;
            Console.WriteLine($"result of num1 < num2 is {isLower}");

            // equality operator
            bool isEqual = num1 == num2;
            Console.WriteLine($"result of num1 == num2 is {isLower}");

            isEqual = num1 != num2;
            Console.WriteLine($"result of num1 != num2 is {isLower}");

            // conditional operators 
            // conditonal AND operator
            bool isLowerAndSunny = isLower && isSunny; // false and true is false
            Console.WriteLine($"result of isLower && isSunny is {isLowerAndSunny}");

            // conditional OR operator
            isLowerAndSunny = isLower || isSunny; // false or true is true
            Console.WriteLine($"result of isLower || isSunny is {isLowerAndSunny}");

            Console.ReadKey();
        }
    }
}
