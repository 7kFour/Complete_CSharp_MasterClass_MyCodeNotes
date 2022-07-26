using System;

namespace Sec7_Switch_Foreach_InstructorSolution {
    internal class Program {
        static void Main(string[] args) {
            // I think this is the same as `bool`
            Boolean valid = false;
            string inputValueType = String.Empty;

            Console.Write("Enter a value: ");
            string inputValue = Console.ReadLine();

            Console.WriteLine("Select the Data type to validate the input you have entered");
            Console.WriteLine("Press 1 for String");
            Console.WriteLine("Press 2 for Integer");
            Console.WriteLine("Press 3 for Boolean");

            Console.Write("Enter: ");
            int inputType = Convert.ToInt32(Console.ReadLine());

            switch (inputType) {
                case 1:
                    //check for string
                    valid = IsAllAlphabetic(inputValue);
                    inputValueType = "String";
                    break;
                case 2:
                    int retValue = 0;
                    //check for integer
                    valid = int.TryParse(inputValue, out retValue);
                    inputValueType = "Integer";
                    break;
                case 3:
                    bool retFlag = false;
                    //check for boolean
                    valid = bool.TryParse(inputValue, out retFlag);
                    inputValueType = "Boolean";
                    break;
                default:
                    inputValueType = "unknown";
                    Console.WriteLine("Not able to detect input type");
                    break;
            }

            Console.WriteLine($"You have entere a value : {inputValue}");
            if (valid) {
                Console.WriteLine($"It is valid: {inputValueType}");
            } else {
                Console.WriteLine($"It is invalid: {inputValueType}");
            }

        }
        /// <summary>
        ///  function check if input string is a pure letter string.
        /// </summary>
        /// <param name="inputValue"></param>
        /// <returns></returns>
        static bool IsAllAlphabetic(string inputValue) {
            foreach (char c in inputValue) {
                if (!char.IsLetter(c)) {
                    return false;
                }
            }

            return true;
        }
    }
}
