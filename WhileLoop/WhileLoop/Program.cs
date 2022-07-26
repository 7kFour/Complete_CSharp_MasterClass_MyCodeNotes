using System;

namespace WhileLoop {
    internal class Program {
        static void Main(string[] args) {
            // the while loop checks first before it does anything 

            //create a loop that increases the counter
            //each time the user presses the enter key on a blank space / empty space
            //when the user enters any character / int then the program will quit
            int counter = 0;
            string userInput = "";

            while (userInput.Equals("")) {
                Console.WriteLine("Please enter to increase count by 1.");
                Console.WriteLine("Enter any characters or integers and press enter to stop counting.");

                userInput = Console.ReadLine();
                Console.WriteLine($"Current count of people is: {counter}\n");
                counter++;
            }
            Console.WriteLine($"Final count was {counter}");

        }
    }
}
