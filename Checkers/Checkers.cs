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
            //make sure encoding is instantiated for printing checker objects
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //instantiates a game object so that the game will run
            Game game = new Game ();

            Console.ReadLine ();

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

        //the grid is the array used to draw the board
        public string[][] Grid { get; set; }
        //list of checker objects used to position checkers on the board
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

        public void DrawBoard () {
            // this will take the grid and draw a board
            Console.WriteLine ("  0 1 2 3 4 5 6 7");

            for (int i = 0; i < Grid.Length; i++) // loop each Row
            {
                string column = $"{i} "; // Show the row index

                for (int e = 0; e < Grid[i].Length; e++) // loop Columns
                {
                    column += $"{Grid[i][e]} ";
                }

                Console.WriteLine (column);
            }
            return;
        }

        public void PlaceCheckers () {
            // this is a method to place checkers on a board when a position is declared (pre || post validation)
            foreach (var checker in Checkers) {
                this.Grid[checker.Position[0]][checker.Position[1]] = checker.Symbol;
            }
            return;
        }

        // if row or column are greater than array throw exception
        // ELSE
        //queries a checker object and finds the checker the user asked for
        public Checker SelectCheckerSource (int sourceRow, int sourceColumn) {
            //if source row and column in array
            if ((sourceRow < 0 || sourceRow > 7) || (sourceColumn < 0 || sourceColumn > 7)) {
                //throw new Exception ("Your move is off the board.");
                Console.WriteLine ("Your move is off the board.");

            }
            return Checkers.Find (cx=> cx.Position.SequenceEqual (new List<int> { sourceRow, sourceColumn }));
        }

        public Checker SelectCheckerDestination (int destRow, int destColumn) {
            //if source row and column in array
            if ((destRow < 0 || destRow > 7) || (destColumn < 0 || destColumn > 7)) {
                //throw new Exception ("Your move is off the board.");
                Console.WriteLine ("Your move is off the board.");
            }
            return Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { destRow, destColumn }));
        }

        //takes in row and column and determines if the space is null (available)
        // if foreach checker in checkers any chosen position == an existing checker position throw exception otherwise valid
        public Checker CheckerPreCheck (int sourceRow, int sourceColumn, int destRow, int destColumn) {
            Checker cx1 = Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> {sourceRow, sourceColumn }));
            // if dest row and dest col have a checker piece using select checker method passing dest
            if (SelectCheckerDestination (destRow, destColumn) != null) {
                //throw new Exception ("That space is taken.");
                Console.WriteLine ("That space is taken.");
            }
            if (SelectCheckerDestination (destRow, destColumn) == null) {
                //check for a diagonal move
                if (Math.Abs (destRow - cx1.Position[0]) == 1 &&
                    Math.Abs (destColumn - cx1.Position[1]) == 1) {
                    Console.WriteLine ("Nice diagonal move");
                    return Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { destRow, destColumn }));
                } else {
                    //throw new Exception ("Move is not diagonal");
                    Console.WriteLine ("Not Diagonal");
                }

            }

            return Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { destRow, destColumn }));
        }

        /*
            takes in sx.position && cx.position checks diagonal move
            if diagonal and player can jump allow jump and remove checker
            checker color and position
         */

        //master validation method contains all above checks and returns a checker object for moving

        //allows a checker to be removed
        public void RemoveChecker (int destRow, int destColumn) {
            Checker cx = SelectCheckerDestination (destRow, destColumn);
            Checkers.Remove (cx);
        }
        public bool CheckForWin () {
            return Checkers.All (x => x.Color == "red") || !Checkers.Exists (x => x.Color == "red");
        }

    }

    class Game {
        public Game () {
            //initialize the game by creating a board object and apply board methods
            Board board = new Board ();
            board.CreateBoard ();
            board.GenerateCheckers ();
            board.PlaceCheckers ();

            do {
                //draw the board to play. on loop checkers will remember they have new positions.
                board.DrawBoard ();
                //Select a Checker
                Console.WriteLine ("Would you like to move a piece or remove a piece?");
                Console.WriteLine ("Type 'move' or 'remove'...");
                string input = Console.ReadLine ().ToLower ().Trim ();
                Console.WriteLine ("Pickup Row:");
                int sourceRow = Int32.Parse (Console.ReadLine ());
                Console.WriteLine ("Pickup Column:");
                int sourceColumn = Int32.Parse (Console.ReadLine ());
                Checker cx = board.SelectCheckerSource (sourceRow, sourceColumn);
                //Choose a move
                Console.WriteLine ("Place row:");
                int destRow = Int32.Parse (Console.ReadLine ());
                Console.WriteLine ("Place column:");
                int destColumn = Int32.Parse (Console.ReadLine ());
                board.CheckerPreCheck (sourceRow, sourceColumn, destRow, destColumn);

                cx.Position = new int[] { destRow, destColumn };
                //need to put master check method here

                // if (input == "remove") {
                //     Console.WriteLine ("Remove row:");
                //     row = Int32.Parse (Console.ReadLine ());
                //     Console.WriteLine ("Remove column:");
                //     column = Int32.Parse (Console.ReadLine ());
                //     board.RemoveChecker (row, column);

                // }
                board.CreateBoard ();
                board.PlaceCheckers ();

            }
            while (!board.CheckForWin ());

        }
    }
}