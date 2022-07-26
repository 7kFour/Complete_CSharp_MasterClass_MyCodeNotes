using System;

namespace IfElseTryParse {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Please enter a temperature in Fahrenheit:");
            string userInput = Console.ReadLine();
            int temp = 0;
            int number = 0;

            // (what we want to parse, out where we want to put the result of that parsing
            // if it's successful
            // the result of .TryParse is a bool - that's why it works in an if statement
            if (int.TryParse(userInput, out number)) {
                temp = number;
            } else {
                Console.WriteLine("No number entered - temperature set as zero.");
            }

            if (temp <= 40) {
                Console.WriteLine("take your coat");

            } else if (temp > 40 && temp < 70) {
                Console.WriteLine("wear a hoodie and pants");

            } else if (temp >= 70 && temp <= 115) {
                Console.WriteLine("tshirt and shorts weather, probably sunscreen too!");
            } else {
                Console.WriteLine("You shouldn't be outside.");
            }

            Console.Read();
        }
    }
}

