using System;

namespace TicTacToe
{
    class Program
    {
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
            new string[] {"0,0", "0,1", "0,2"},
            new string[] {"1,0", "1,1", "1,2"},
            new string[] {"2,0", "2,1", "2,2"}
        };

        public static void Main()
        {
            do
            {
                DrawBoard();
                GetInput();

            } while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
        }

        public static void PlaceMark(int row, int column)
        {
        // your code goes here
        }

        public static bool CheckForWin()
        {
            // your code goes here

            return false;
        }

        public static bool CheckForTie()
        {
            // your code goes here

            return false;
        }
        
        public static bool HorizontalWin()
        {
        // check each row for same player input

        return false;
        }

        public static bool VerticalWin()
        {
            // check each column for same player input

            return false;
        }

        public static bool DiagonalWin()
        {
            // check ["0,0"; "1,1"; "2,2"] && check ["0,2" ; "1,1" ; "2,0"]


            return false;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("   0   1   2  ");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  ------------");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  ------------");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
        //add unit tests
    }
}
