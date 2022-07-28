using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec7_TicTacToe_Game {
    internal class GameBoard {

        private string[,] board = new string[,]{
            {"1","2","3"},
            {"4","5","6"},
            {"7","8","9"}
        };

        public string[,] theBoard {
            get {
                return board;
            }
        }

        // method sets value at player specified field 
        // int represents player to identify if O or X should be used 
        public void SetValue(string v, int p) {
            if (p == 1) {
                switch (v) {
                    case "1":
                        if (!board[0, 0].Equals("X") && !board[0, 0].Equals("O")) {
                            board[0, 0] = "X";
                        }
                        break;

                    case "2":
                        if (!board[0, 1].Equals("X") && !board[0, 1].Equals("O")) {
                            board[0, 1] = "X";
                        }
                        break;

                    case "3":
                        if (!board[0, 2].Equals("X") && !board[0, 2].Equals("O")) {
                            board[0, 2] = "X";
                        }
                        break;

                    case "4":
                        if (!board[1, 0].Equals("X") && !board[1, 0].Equals("O")) {
                            board[1, 0] = "X";
                        }
                        break;

                    case "5":
                        if (!board[1, 1].Equals("X") && !board[1, 1].Equals("O")) {
                            board[1, 1] = "X";
                        }
                        break;

                    case "6":
                        if (!board[1, 2].Equals("X") && !board[1, 2].Equals("O")) {
                            board[1, 2] = "X";
                        }
                        break;

                    case "7":
                        if (!board[2, 0].Equals("X") && !board[2, 0].Equals("O")) {
                            board[2, 0] = "X";
                        }
                        break;

                    case "8":
                        if (!board[2, 1].Equals("X") && !board[2, 1].Equals("O")) {
                            board[2, 1] = "X";
                        }
                        break;

                    case "9":
                        if (!board[2, 2].Equals("X") && !board[2, 2].Equals("O")) {
                            board[2, 2] = "X";
                        }
                        break;

                    default:
                        break;
                }
            } else {
                switch (v) {
                    case "1":
                        if (!board[0, 0].Equals("X") && !board[0, 0].Equals("O")) {
                            board[0, 0] = "O";
                        }
                        break;

                    case "2":
                        if (!board[0, 1].Equals("X") && !board[0, 1].Equals("O")) {
                            board[0, 1] = "O";
                        }
                        break;

                    case "3":
                        if (!board[0, 2].Equals("X") && !board[0, 2].Equals("O")) {
                            board[0, 2] = "O";
                        }
                        break;

                    case "4":
                        if (!board[1, 0].Equals("X") && !board[1, 0].Equals("O")) {
                            board[1, 0] = "O";
                        }
                        break;

                    case "5":
                        if (!board[1, 1].Equals("X") && !board[1, 1].Equals("O")) {
                            board[1, 1] = "O";
                        }
                        break;

                    case "6":
                        if (!board[1, 2].Equals("X") && !board[1, 2].Equals("O")) {
                            board[1, 2] = "O";
                        }
                        break;

                    case "7":
                        if (!board[2, 0].Equals("X") && !board[2, 0].Equals("O")) {
                            board[2, 0] = "O";
                        }
                        break;

                    case "8":
                        if (!board[2, 1].Equals("X") && !board[2, 1].Equals("O")) {
                            board[2, 1] = "O";
                        }
                        break;

                    case "9":
                        if (!board[2, 2].Equals("X") && !board[2, 2].Equals("O")) {
                            board[2, 2] = "O";
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        // displays board on console 
        public void DisplayBoard() {

            for (int i = 0; i < board.GetLength(0); i++) {
                Console.Write("     |     |     \n");

                for (int j = 0; j < board.GetLength(1); j++) {
                    
                    if (j < 2) {
                        Console.Write($"  {board[i, j]}  |");
                    } else {
                        Console.Write($"  {board[i, j]}   ");
                    }

                    if (j == 2 && i < 2) {
                        Console.Write("\n_____|_____|_____\n");
                    } 
                }
            }

            Console.Write("\n     |     |     \n");
        }
    }
}















