using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Checkers {
    class Program {
        static void Main (string[] args) {
            // intro game
            Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine ("~~~~~~~~CHECKERS~~~~~~~~~");
            Console.WriteLine ("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Thread.Sleep (2000);
            //make sure encoding is instantiated
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Game game = new Game();

            Console.ReadLine();

        }
    }
    //This creates the checkers with the ability to be assigned a symbol(circleId),position(on board) and a color.
    public class Checker {
        public string Symbol { get; set; }
        public int[] Position { get; set; }
        public string Color { get; set; }

        public Checker (string color, int[] position) {
            int circleId;

            if (color == "black") {
                //creates a circle with a b inside for "BLACK"
                circleId = int.Parse ("24D1", System.Globalization.NumberStyles.HexNumber);
            } else {
                //creates a circle with an r inside for "RED"
                circleId = int.Parse ("24E1", System.Globalization.NumberStyles.HexNumber);
            }
            this.Symbol = char.ConvertFromUtf32 (circleId);
            this.Position = position;
            this.Color = color;
        }
    }

    public class Board {
        public string[][] Grid { get; set; }
        public List<Checker> Checkers { get; set; }

        public Board () {
            //when instantiating a board the board will need a list of checkers to create a board
            this.Checkers = new List<Checker> ();
            this.CreateBoard ();
            return;
        }

        public void CreateBoard () {
            // create the grid where all the pieces will be placed
            this.Grid = new string[][] {
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
                new string[] { " ", " ", " ", " ", " ", " ", " ", " " },
            };
            return;
        }

        public void GenerateCheckers () {
            // red checkers array (positions initial)
            int[][] redCheckers = new int[][] {
                new int[] { 0, 1 }, new int[] { 0, 3 }, new int[] { 0, 5 }, new int[] { 0, 7 },
                new int[] { 1, 0 }, new int[] { 1, 2 }, new int[] { 1, 4 }, new int[] { 1, 6 },
                new int[] { 2, 1 }, new int[] { 2, 3 }, new int[] { 2, 5 }, new int[] { 2, 7 }
            };
            //black checkers array (positions initial)
            int[][] blackCheckers = new int[][] {
                new int[] { 5, 0 }, new int[] { 5, 2 }, new int[] { 5, 4 }, new int[] { 5, 6 },
                new int[] { 6, 1 }, new int[] { 6, 3 }, new int[] { 6, 5 }, new int[] { 6, 7 },
                new int[] { 7, 0 }, new int[] { 7, 2 }, new int[] { 7, 4 }, new int[] { 7, 6 }
            };
            //for loop will assign color values to each checker that is in a position
            for (int i = 0; i < 12; i++) {
                Checker red = new Checker ("red", redCheckers[i]);
                Checker black = new Checker ("black", blackCheckers[i]);
                this.Checkers.Add (red);
                this.Checkers.Add (black);
            }
            return;
        }

        public void PlaceCheckers () {
            // this is a method to place checkers on a board when a position is declared
            foreach (var checker in Checkers) {
                this.Grid[checker.Position[0]][checker.Position[1]] = checker.Symbol;
            }
            return;
        }

        public void DrawBoard () {
            // this will take the grid and draw a board
            Console.WriteLine ("  0 1 2 3 4 5 6 7");

            for (var i = 0; i < Grid.Length; i++) // loop each Row
            {
                string column = $"{i} "; // Show the row index

                for (var e = 0; e < Grid[i].Length; e++) // Column
                {
                    column += $"{Grid[i][e]} ";
                }

                Console.WriteLine (column);
            }
            return;
        }
        // selects a checker to be played
        public Checker SelectChecker (int row, int column) {
            return Checkers.Find (x => x.Position.SequenceEqual (new List<int> { row, column }));
        }
        //allows a checker to be removed
        public void RemoveChecker (int row, int column) {
            var c = SelectChecker (row, column);
            Checkers.Remove (c);
        }

        public bool CheckForWin () {
            return Checkers.All (x => x.Color == "red") || !Checkers.Exists (x => x.Color == "red");
        }
    }

    class Game {
        public Game () {
            Board board = new Board ();
            board.CreateBoard ();
            board.GenerateCheckers ();
            board.PlaceCheckers ();

            do {
                board.DrawBoard ();
                // Make moves
                Console.WriteLine ("Move or remove?");
                string input = Console.ReadLine ();
                Console.WriteLine ("Pickup Row:");
                int row = Int32.Parse (Console.ReadLine ());
                Console.WriteLine ("Pickup Column:");
                int column = Int32.Parse (Console.ReadLine ());
                var c = board.SelectChecker (row, column);
                Console.WriteLine ("Place row:");
                row = Int32.Parse (Console.ReadLine ());
                Console.WriteLine ("Place column:");
                column = Int32.Parse (Console.ReadLine ());
                c.Position = new int[] { row, column };

                if (input == "remove") {
                    Console.WriteLine ("Remove row:");
                    row = Int32.Parse (Console.ReadLine ());
                    Console.WriteLine ("Remove column:");
                    column = Int32.Parse (Console.ReadLine ());
                    board.RemoveChecker (row, column);

                }
                board.CreateBoard ();
                board.PlaceCheckers ();

            }
            while (!board.CheckForWin ());

        }
    }
}