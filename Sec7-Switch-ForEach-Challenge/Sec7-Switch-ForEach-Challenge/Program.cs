using System;
using System.Linq;

namespace Sec7_Switch_ForEach_Challenge {
    internal class Program {
        static void Main(string[] args) {

            // print welcome message
            Console.WriteLine("Welcome to the switch statement exercise!\n");

            // prompt and take 1st user input 
            Console.Write("Please enter either a string, integer, or boolean value: ");
            string theInput = Console.ReadLine();

            // output selection menu
            // would be better to use a dictionary - but we haven't learned that yet
            // so I'm going to stick only what we have used in the class 
            string[] dTypes = { "String", "Integer", "Bool" };
            Console.WriteLine("\nSelect the data type of the input you entered:");
            for (int i = 0; i < dTypes.Length; i++) {
                // add 1 to i to account for arrays starting at 0
                Console.WriteLine($"Press {i + 1} for {dTypes[i]} ");
            }

            // prompt and take 2nd user input
            Console.Write("Enter Selection: ");
            string dataSelection = Console.ReadLine();

            // check if user input is valid 
            int theInt = 0;
            bool tryInt = false;

            bool theBool = false;
            bool tryBool = false;

            bool nonNumericString = false;
            if (theInput.Any(char.IsDigit)) {
                nonNumericString = true;
            } 

            // make sure user entered something
            // check types 
            if (!string.IsNullOrEmpty(theInput)) {

                tryBool = bool.TryParse(theInput, out theBool);
                tryInt = int.TryParse(theInput, out theInt);
            }

            // variables for data selection choice
            int dS;
            bool tryDs = int.TryParse(dataSelection, out dS);

            // check if user input matches 2nd input value 
            // then output what they entered and if it is valid
            // subtract 1 from dS to account for array starting at 0
            switch (dataSelection) {

                case "1":
                    if (tryInt) {
                        Console.WriteLine($"\nYou have entered: {theInput}\nIt is not a valid: {dTypes[dS - 1]}");
                    } else if (tryBool) {
                        Console.WriteLine($"\nYou have entered: {theInput}\nIt is not a valid: {dTypes[dS - 1]}");
                    } else if (nonNumericString){
                        Console.WriteLine($"\nYou have entered: {theInput}\nIt is not a valid: {dTypes[dS - 1]}");
                    } else {
                        Console.WriteLine($"\nYou have entered: {theInput}\nIt is a valid: {dTypes[dS - 1]}");
                    }
                    break;

                case "2":
                    if (tryInt) {
                        Console.WriteLine($"\nYou have entered: {theInput}\nIt is a valid: {dTypes[dS - 1]}");
                    } else {
                        Console.WriteLine($"\nYou have entered: {theInput}\nIt is not a valid: {dTypes[dS - 1]}");
                    }
                    break;

                case "3":
                    if (tryBool) {
                        Console.WriteLine($"\nYou have entered: {theInput}\nIt is a valid: {dTypes[dS - 1]}");
                    } else {
                        Console.WriteLine($"\nYou have entered: {theInput}\nIt is not a valid: {dTypes[dS - 1]}");
                    }
                    break;

                default:
                    Console.WriteLine("nothing selected");
                    break;
            }

        }
    }
}
