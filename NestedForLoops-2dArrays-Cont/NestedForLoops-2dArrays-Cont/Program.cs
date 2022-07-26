using System;

namespace NestedForLoops_2dArrays_Cont {
    internal class Program {

        static int[,] matrix = {
            {1,2,3}, // 3 = 0,2
            {4,5,6}, // 5 = 1,1
            {7,8,9}  // 7 = 2,0
        };

        // using strings so that I can X and O to this for the tic tac toe exercise sec 7 ex 8 
        static string[,] ticTacCheck = {
            {"1","2","3"}, 
            {"4","5","6"}, 
            {"7","8","9"}  
        };

        static string[,] ticTacDiagLR = {
            {"X","2","3"},
            {"4","X","6"},
            {"7","8","X"}
        };

        static string[,] ticTacDiagRL = {
            {"1","2","O"},
            {"4","O","6"},
            {"O","8","9"}
        };

        static void Main(string[] args) {
            // print only 3,5,7 - the diagonals
            //for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--) {
            //    Console.WriteLine(matrix[i,j]);
            //}

            // print diagonals - from top right to bottom left [0,2], [1,1], [2, 0]
            // don't really need the variables 
            // memorize this
            int mLenRow = ticTacDiagRL.GetLength(0);
            int mLenCol = ticTacDiagRL.GetLength(1);
            int playerOneScore = 0;
            int playerTwoScore = 0;

            for (int i = 0; i < mLenRow; i++) {
                for (int j = 0; j < mLenCol; j++) {
                    
                    // if i+j == length of array - 1
                    if ((i + j) == (mLenRow - 1)) {
                        if (ticTacDiagRL[i, j].Equals("X")) {
                            playerOneScore++;
                        } else if (ticTacDiagRL[i, j].Equals("O")) {
                            playerTwoScore++;
                        }
                    }
                }
            }

            if (playerOneScore == 3) {
                Console.WriteLine("Player 1 wins!");
            } else if (playerTwoScore == 3) {
                Console.WriteLine("Player 2 wins!");
            } else {
                Console.WriteLine("No winner here!");
            }

            // print diagonals from top left to bottom right 
            // [0,0], [1,1], [2,2]
            int pOneScoreGame2 = 0;
            int pTwoScoreGame2 = 0;

            for (int i = 0; i < ticTacDiagLR.GetLength(0); i++) {
                for (int j = 0; j < ticTacDiagLR.GetLength(1); j++) {

                    // if i == j because we want [0,0], [1,1], [2,2]
                    if ((i == j)) {
                        if (ticTacDiagLR[i, j].Equals("X")) {
                            pOneScoreGame2++;
                        } else if (ticTacDiagLR[i, j].Equals("O")) {
                            pTwoScoreGame2++;
                        }
                    }
                }
            }

            if (pOneScoreGame2 == 3) {
                Console.WriteLine("Player 1 wins game two!");
            } else if (pTwoScoreGame2 == 3) {
                Console.WriteLine("Player 2 wins game two!");
            } else {
                Console.WriteLine("No winner here!");
            }


        }
    }
}
