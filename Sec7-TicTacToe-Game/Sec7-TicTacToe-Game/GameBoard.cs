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

        public void SetValue(string v, int p) {
            if (p == 1) {
                switch (v) {
                    case "1":
                        board[0, 0] = "X";
                        break;
                    case "2":
                        board[0, 1] = "X";
                        break;
                    case "3":
                        board[0, 2] = "X";
                        break;
                    case "4":
                        board[1, 0] = "X";
                        break;
                    case "5":
                        board[1, 1] = "X";
                        break;
                    case "6":
                        board[1, 2] = "X";
                        break;
                    case "7":
                        board[2, 0] = "X";
                        break;
                    case "8":
                        board[2, 1] = "X";
                        break;
                    case "9":
                        board[2, 2] = "X";
                        break;
                    default:
                        break;
                }
            } else {
                switch (v) {
                    case "1":
                        board[0, 0] = "O";
                        break;
                    case "2":
                        board[0, 1] = "O";
                        break;
                    case "3":
                        board[0, 2] = "O";
                        break;
                    case "4":
                        board[1, 0] = "O";
                        break;
                    case "5":
                        board[1, 1] = "O";
                        break;
                    case "6":
                        board[1, 2] = "O";
                        break;
                    case "7":
                        board[2, 0] = "O";
                        break;
                    case "8":
                        board[2, 1] = "O";
                        break;
                    case "9":
                        board[2, 2] = "O";
                        break;
                    default:
                        break;
                }
            }
        }

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















