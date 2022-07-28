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

                // for player 1
                // validate entered string - make it lowercase for easier checks
                if (!playerChoice.ToLower().Equals("q") && ValidateChoice(playerChoice.ToLower())) {
                    // change array value to X (pl1) or O (pl2) 
                    // if their input is valid 

                    // make sure that spot is open on board - in switch in class
                    // set board value with class member method
                    board.SetValue(playerChoice, 1);
                } else {
                    // exit game loop if player choice is q
                    Console.WriteLine("Exiting game, thanks!");
                    break;
                }

                // update board so that user input appears
                Console.Clear();
                board.DisplayBoard();

                Console.Write("\nPlayer 2 - Choose field: ");
                playerChoice = Console.ReadLine();

                // for player 2
                // validate entered string - make it lowercase for easier checks
                if (!playerChoice.ToLower().Equals("q") && ValidateChoice(playerChoice.ToLower())) {
                    // change array value to X (pl1) or O (pl2) 
                    // if their input is valid 
                    Console.WriteLine(playerChoice);

                    // make sure that spot is open on board - in switch in class
                    // set board value with class member 
                    board.SetValue(playerChoice, 2);
                } else {
                    // exit game loop if player choice is q
                    Console.WriteLine("Exiting game, thanks!");
                    break;
                }

                Console.Clear();

                // check win condition


                // when a player wins ask if they want to play again 
                // or quit 


                // end game loop and exit program 
                if (playerChoice.ToLower() == "q") {
                Console.WriteLine("Exiting Game - Goodbye!");
                exitCondition = false; 
                }
            }
        }

        // check that player choice is a string between 1-9
        static bool ValidateChoice (string choice) {
            // if string is empty - return false            
            if (String.IsNullOrEmpty(choice)) {
                return false;
            }

            // check that entered string is 1-9 or q
            switch (choice) {
                case "1":
                    return true;
                    
                case "2":
                    return true;
                    
                case "3":
                    return true;
                    
                case "4":
                    return true;
                    
                case "5":
                    return true;
                    
                case "6":
                    return true;
                    
                case "7":
                    return true;
                    
                case "8":
                    return true;
                    
                case "9":
                    return true;
                    
                case "q":
                    return true;
                    
                default:
                    return false;

            }

            
        }

        // instructions - printed to console
        static void IntroMessage() {
            Console.WriteLine("Welcome Players!\n");
            Console.WriteLine("Player 1 will be X and Player 2 will be O");
            Console.WriteLine("Please enter the number of a field above to capture it.\n");
            Console.WriteLine("You may press Q or q at any time to quit.\n");
            Console.WriteLine("------------------------------------------------------------\n");
        }

        
    }
}
