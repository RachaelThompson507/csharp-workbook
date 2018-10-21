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

            if (CheckForWin()== true){
                DrawBoard();
                Console.WriteLine("There is a WINNER. It is NOT player {0}!", playerTurn);
            } else if (CheckForTie () == true) {
                DrawBoard();
                Console.WriteLine("This game is a TIE!");
            }

            // leave this command at the end so your program does not close automatically
            Console.WriteLine("Press Enter to Close Application");
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
                GetInput ();
                //ternary opporator changes the player.
                playerTurn = (playerTurn == "X") ? "O" : "X";
            }
            return playerTurn;
        }

        public static bool CheckForWin () {
            // your code goes here
            if (HorizontalWin () == true) {
                return true;
            } else if (VerticalWin () == true) {
                return true;
            } else if (DiagonalWin () == true) {
                return true;
            } else {
                return false;
            }
        }

        public static bool CheckForTie () {
            // your code goes here
            int spaceAvail = 9;
            for (int i = 0; i < board.Length; i++) {
                for (int j = 0; j < board[i].Length; j++) {
                    if (board[i][j] == "X" || board[i][j] == "O") {
                        spaceAvail--;
                    }
                }
            }
            if (spaceAvail <= 0 && !CheckForWin () == true) {
                return true;
            } else {
                return false;
            }
        }

        public static bool HorizontalWin () {
            // check each row for same player input
            if (board[0][0] == "X" && board[0][1] == "X" && board[0][2] == "X") {
                return true;
            } else if (board[0][0] == "O" && board[0][1] == "O" && board[0][2] == "O") {
                return true;
            } else if (board[1][0] == "X" && board[1][1] == "X" && board[1][2] == "X") {
                return true;
            } else if (board[1][0] == "O" && board[1][1] == "O" && board[1][2] == "O") {
                return true;
            } else if (board[2][0] == "X" && board[2][1] == "X" && board[2][2] == "X") {
                return true;
            } else if (board[2][0] == "O" && board[2][1] == "O" && board[2][2] == "O") {
                return true;
            } else {
                return false;
            }
        }

        public static bool VerticalWin () {
            // check each column for same player input
            if (board[0][0] == "X" && board[1][0] == "X" && board[2][0] == "X") {
                return true;
            } else if (board[0][0] == "O" && board[1][0] == "O" && board[2][0] == "O") {
                return true;
            } else if (board[0][1] == "X" && board[1][1] == "X" && board[2][1] == "X") {
                return true;
            } else if (board[0][1] == "O" && board[1][1] == "O" && board[2][1] == "O") {
                return true;
            } else if (board[0][2] == "X" && board[1][2] == "X" && board[2][2] == "X") {
                return true;
            } else if (board[0][2] == "O" && board[1][2] == "O" && board[2][2] == "O") {
                return true;
            } else {
                return false;
            }
        }

        public static bool DiagonalWin () {
            // check ["0,0"; "1,1"; "2,2"] && check ["0,2" ; "1,1" ; "2,0"]
            if (board[0][0] == "X" && board[1][1] == "X" && board[2][2] == "X") {
                return true;
            } else if (board[0][0] == "O" && board[1][1] == "O" && board[2][2] == "O") {
                return true;
            } else if (board[0][2] == "O" && board[1][1] == "O" && board[2][0] == "O") {
                return true;
            } else if (board[0][2] == "O" && board[1][1] == "O" && board[2][0] == "O") {
                return true;
            } else {
                return false;
            }
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