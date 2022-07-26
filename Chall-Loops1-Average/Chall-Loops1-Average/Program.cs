using System;

namespace Chall_Loops1_Average {
    internal class Program {
        static void Main(string[] args) {

            // enter each score manually
            // get final average when entering -1
            // must not use a data structure eg array
            // can only enter integers between 0-20 
            int score = 0;
            int totalScore = 0;
            int count = 0;
            string userInput = string.Empty;
            float avgScore = 0.0f;

            while (true) {
                // print instructions
                InstructionOutput();
                // ask for and store user input
                userInput = UserInput();
                // try to cast user input to int 
                bool inputCheck = int.TryParse(userInput, out score);

                // if parse good - make sure score in parameters
                if (inputCheck && score >= 0 && score <= 20) {
                    Console.WriteLine("Score saved!");
                    totalScore += score;
                    count++;
                // if inputCheck is false - warn user then go back to start of loop
                } else if (!inputCheck) {
                    Console.WriteLine("Please enter a valid score!");
                    continue;
                // if userInput is -1 break out of loop
                } else if (userInput.Equals("-1")) {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
            
            // output count of inputs
            // output total score
            Console.WriteLine($"Count: {count}");
            Console.WriteLine($"Total Score: {totalScore}");

            // if total score and count are higher than 0 calculate and print average for user
            if (totalScore > 0 && count > 0) {
                avgScore =  (float)totalScore / (float)count;
                Console.WriteLine($"Average: {avgScore}");
            } 
        }

        // InstructionOutput prints out instructional menu
        public static void InstructionOutput() {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Welcome to ScoreTracker");
            Console.WriteLine("Please enter scores between 0-20");
            Console.WriteLine("When you are ready to exit the program input \"-1\" and press enter");
            Console.WriteLine("Then you will receive an average and count of scores entered");
            Console.WriteLine("-------------------------------------------------------------------------");
        }     
        
        // ask for and return user input as string
        public static string UserInput() {
            Console.Write("Please enter score: ");
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}
