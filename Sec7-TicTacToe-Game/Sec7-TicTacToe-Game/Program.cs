using System;

namespace Sec7_TicTacToe_Game {
    internal class Program {
        static void Main(string[] args) {
            bool exitCondition = true;
            string playerChoice = string.Empty;

            GameBoard board = new GameBoard();

            // display intro message
            IntroMessage();

            // main game loop
            while (exitCondition) {

                // display game board
                board.DisplayBoard();


                // prompt player for input
                // validate input
                // ask for input until player gives valid input 
                Console.Write("\nPlayer 1 - Choose field: ");
                playerChoice = Console.ReadLine();

                // make a setter function or setter property for the value
                if (!playerChoice.ToLower().Equals("q") && ValidateChoice(playerChoice)) {
                    // change array value to X (pl1) or O (pl2) 
                    // if their input is valid 
                    Console.WriteLine(playerChoice);
                    // call setter here
                } else {
                    Console.WriteLine("reeee");
                    break;
                }

                Console.Write("\nPlayer 2 - Choose field: ");
                playerChoice = Console.ReadLine();

                if (!playerChoice.ToLower().Equals("q") && ValidateChoice(playerChoice)) {
                    // change array value to X (pl1) or O (pl2) 
                    // if their input is valid 
                    Console.WriteLine(playerChoice);
                    // call setter here
                } else {
                    Console.WriteLine("reeee");
                    break;
                }

                Console.Clear();

                // check score 

                // when a player wins ask if they want to play again 
                // or quit 


                // end game loop and exit program 
                if (playerChoice.ToLower() == "q") {
                Console.WriteLine("Exiting Game - Goodbye!");
                exitCondition = false; 
                }
            }

            board.SetValue("truck");
            board.GetBoard();

            Console.Read();
        }

        // check that player choice is a string between 1-9
        static bool ValidateChoice (string choice) {
            if (String.IsNullOrEmpty(choice)) {
                return false;
            }

            switch (choice) {
                case "1":
                    return true;
                    break;
                case "2":
                    return true;
                    break;
                case "3":
                    return true;
                    break;
                case "4":
                    return true;
                    break;
                case "5":
                    return true;
                    break;
                case "6":
                    return true;
                    break;
                case "7":
                    return true;
                    break;
                case "8":
                    return true;
                    break;
                case "9":
                    return true;
                    break;
                case "q":
                    return true;
                    break;
                default:
                    return false;

            }

            
        }

        // instructions
        static void IntroMessage() {
            Console.WriteLine("Welcome Players!\n");
            Console.WriteLine("Player 1 will be X and Player 2 will be O");
            Console.WriteLine("Please enter the number of a field above to capture it.\n");
            Console.WriteLine("You may press Q or q at any time to quit.\n");
            Console.WriteLine("------------------------------------------------------------\n");
        }

        
    }
}
