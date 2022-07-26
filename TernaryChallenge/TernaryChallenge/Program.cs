using System;

namespace TernaryChallenge {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Please enter a temperature in celsius: ");
            int temp = 0;
            bool userInputTemp = int.TryParse(Console.ReadLine(), out temp);

            if (userInputTemp) {
                string outMessage = temp <= 15 ? "It's too cold here!" : temp >= 16 && temp <= 28 ? "It's alright out." : "Bruh, it's hot!";
                Console.WriteLine(outMessage);
            } else {
                Console.WriteLine("Please enter a valid integer value.");
            }

        }
    }
}
