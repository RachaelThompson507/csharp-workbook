using System;

namespace TicTacToe {
    class Program {
        public static string playerTurn = "X";
        public static string[][] board = new string[][] {
            new string[] { " ", " ", " " },
            new string[] { " ", " ", " " },
            new string[] { " ", " ", " " }
        };

        public static void Main () {

            do {
                DrawBoard ();
                GetInput ();

            } while (!CheckForWin () && !CheckForTie ());

            // leave this command at the end so your program does not close automatically
            Console.ReadLine ();
        }

        public static void GetInput () {
            Console.WriteLine ("Player " + playerTurn);
            Console.WriteLine ("Enter Row:");
            int row = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Enter Column:");
            int column = int.Parse (Console.ReadLine ());
            PlaceMark (row, column);
            playerTurn = (playerTurn == "X") ? "O" : "X";
        }

        public static string PlaceMark (int row, int column) {
            //X is default using ternary operator
            if (board[row][column] == " ") {
                board[row][column] = playerTurn;
                return playerTurn;
            } else if (board[row][column] == "X" || board[row][column] == "O") {
                Console.WriteLine ("This space is taken...try again.");

                for (row = 0; row < board.Length; row++) {
                    for (column = 0; column < board[row].Length; column++) {
                        board[row][column] = " ";
                        GetInput ();
                        if (board[row][column] == " ") {
                            board[row][column] = playerTurn;
                            return playerTurn;
                        } else {
                            return "Something is wrong, get help.";
                        }
                    }
                }
            }
            //playerTurn = (playerTurn == "X") ? "O" : "X";
            return playerTurn;
        }

        public static bool CheckForWin () {
            // your code goes here

            return false;
        }

        public static bool CheckForTie () {
            // your code goes here

            return false;
        }

        public static bool HorizontalWin () {
            // check each row for same player input

            return false;
        }

        public static bool VerticalWin () {
            // check each column for same player input

            return false;
        }

        public static bool DiagonalWin () {
            // check ["0,0"; "1,1"; "2,2"] && check ["0,2" ; "1,1" ; "2,0"]

            return false;
        }

        public static void DrawBoard () {
            Console.WriteLine ("  0 1 2 ");
            Console.WriteLine ("0 " + String.Join ("|", board[0]));
            Console.WriteLine ("  ------");
            Console.WriteLine ("1 " + String.Join ("|", board[1]));
            Console.WriteLine ("  ------");
            Console.WriteLine ("2 " + String.Join ("|", board[2]));
        }
        //add unit tests
    }
}