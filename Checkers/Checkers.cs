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
        public bool King { get; set; }

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
            this.King = false;
        }
    }

    public class Board {
        //variable needed for jumping
        public Checker check;
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
            foreach (Checker checker in Checkers) {
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
            } else if (Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { sourceRow, sourceColumn })) == null) {
                Console.WriteLine ("You're trying to move a checker that doesn't exist.");
                //throw new Exception ("There is not a checker at {0}, {1}.", sourceRow, source Column);
            }
            return Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { sourceRow, sourceColumn }));
        }

        public Checker SelectCheckerDestination (int destRow, int destColumn) {
            Checker check = Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { destRow, destColumn }));
            //if source row and column in array
            if ((destRow < 0 || destRow > 7) || (destColumn < 0 || destColumn > 7)) {
                //throw new Exception ("Your move is off the board.");
                Console.WriteLine ("Your move is off the board.");
            }
            return Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { destRow, destColumn }));
        }

        //takes in row and column and determines if the space is null (available)
        // if during checkers game any chosen position == an existing checker position throw exception otherwise valid
        // if move is not diagonal throw and exception
        public Checker CheckerPreCheck (int sourceRow, int sourceColumn, int destRow, int destColumn, Checker check) {
            check = Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { sourceRow, sourceColumn }));
            // if dest row and dest col have a checker piece using select checker method passing dest
            if (SelectCheckerDestination (destRow, destColumn) != null) {
                //throw new Exception ("That space is taken.");
                Console.WriteLine ("That space is taken.");
            } else if (SelectCheckerDestination (destRow, destColumn) == null) {
                //if moving 2 diagonal spaces jump checker must be opposing (X)
                //1. check if moving two spots (X)
                //2. check if destination removal is not null (&& SelectCheckerDestination(destRow+1,destColumn -1) != null)
                //3. checker symbol being jumped is opposing
                if (Math.Abs (destRow - check.Position[0]) == 2 && Math.Abs (destColumn - check.Position[1]) == 2) {
                    // for black checkers

                    //remove the checker row up  to column right
                    if (destRow - check.Position[0] == -2 && destColumn - check.Position[1] == 2) {
                        RemoveChecker (destRow + 1, destColumn - 1);
                        //Console.WriteLine ("Nice Jump Black, removed checker up and to right.");
                        Console.WriteLine ("Nice Jump");
                    }
                    //remove the checker row up to column left
                    else if (destRow - check.Position[0] == -2 && destColumn - check.Position[1] == -2) {
                        RemoveChecker (destRow + 1, destColumn + 1);
                        //Console.WriteLine ("Nice Jump Black, removed checker up and to left.");
                        Console.WriteLine ("Nice Jump");
                    }
                    //for red checkers

                    //remove the checker row behind me to column right
                    else if (destRow - check.Position[0] == 2 && destColumn - check.Position[1] == 2) {
                        RemoveChecker (destRow - 1, destColumn - 1);
                        //Console.WriteLine ("Nice Jump Red, removed checker behind you and to right.");
                        Console.WriteLine ("Nice Jump");
                    }
                    //remove the checker down to left
                    else if (destRow - check.Position[0] == 2 && destColumn - check.Position[1] == -2) {
                        RemoveChecker (destRow - 1, destColumn + 1);
                        //Console.WriteLine ("Nice Jump Red, removed checker behind you and to the left ");
                        Console.WriteLine ("Nice Jump");
                    }
                    //Console.WriteLine ("Nice Jump");
                    //check for a diagonal move - regular
                } else if (Math.Abs (destRow - check.Position[0]) == 1 &&
                    Math.Abs (destColumn - check.Position[1]) == 1) {
                    Console.WriteLine ("Nice diagonal move!");
                    return Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { destRow, destColumn }));
                } else {
                    Console.WriteLine (" ");
                    //Console.WriteLine ("You cannot move there - not diagonal or jump.");
                    throw new Exception ("You can move here. There are requirements for jumping.");
                }
            }
            return Checkers.Find (cx => cx.Position.SequenceEqual (new List<int> { destRow, destColumn }));
        }

        //allows a checker to be removed
        public void RemoveChecker (int destRow, int destColumn) {
            Checker cx2 = SelectCheckerDestination (destRow, destColumn);
            Checkers.Remove (cx2);
        }
        //king a checker takes in a checker object and a destRow to determine if the Checker is to be Kinged on that move
        public void KingChecker (Checker checker, int destRow) {
            if ((checker.Color == "red" && destRow == 7) || (checker.Color == "black" && destRow == 0)) {
                checker.King = true;
                if (checker.Color == "red") {
                    int kingId = int.Parse ("24C7", System.Globalization.NumberStyles.HexNumber);
                    string king = char.ConvertFromUtf32 (kingId);
                    checker.Symbol = king;
                } else {
                    int kingId = int.Parse ("24B7", System.Globalization.NumberStyles.HexNumber);
                    string king = char.ConvertFromUtf32 (kingId);
                    checker.Symbol = king;
                }
                PlaceCheckers ();
            }
        }
        public bool CheckForWin () {
            return Checkers.All (x => x.Color == "red") || !Checkers.Exists (x => x.Color == "red");
        }
        public void MoveCheckers () {
            //Asks user for a source row/column to get checker to play in the field
            //validates that the checker is in the field of play
            Console.WriteLine ("(Choose a number between 0-7)");
            Console.WriteLine ("Pick up Checker on Row: ");
            int sourceRow = Int32.Parse (Console.ReadLine ().Trim ());
            Console.WriteLine ("Pick up Checker on Column: ");
            int sourceColumn = Int32.Parse (Console.ReadLine ().Trim ());
            Checker cx = SelectCheckerSource (sourceRow, sourceColumn);
            //Asks user for a destination row/column to place checker in the field
            //validates move for diagonal, jump and king
            //return checker position played
            Console.WriteLine ("Place Checker on Row: ");
            int destRow = Int32.Parse (Console.ReadLine ().Trim ());
            Console.WriteLine ("Place Checker on Column: ");
            int destColumn = Int32.Parse (Console.ReadLine ().Trim ());
            CheckerPreCheck (sourceRow, sourceColumn, destRow, destColumn, check);
            cx.Position = new int[] { destRow, destColumn };
            // check for a king 
            KingChecker (cx, destRow);
            //creates the board again
            CreateBoard ();
            //places checkers on the newly created board
            PlaceCheckers ();
            return;
        }

    }

    class Game {
        public Game () {
            // turns
            bool turn = true;

            //initialize the game by creating a board object and apply board methods
            Board board = new Board ();
            board.CreateBoard ();
            board.GenerateCheckers ();
            board.PlaceCheckers ();
            Console.WriteLine ("To play you will select rows and columns\nto move pieces throughout the field.");
            do {
                //draw the board to play. on loop checkers will remember they have new positions.
                board.DrawBoard ();
                //Open how to play
                //Console.WriteLine ("To play you will select rows and columns\nto move pieces throughout the field.");
                if (turn) {
                    Console.WriteLine ();
                    Console.WriteLine ("Red, Prepare to Move");
                    turn = false;
                } else {
                    Console.WriteLine ();
                    Console.WriteLine ("Black, Prepare to Move");
                    turn = true;
                }

                board.MoveCheckers ();
            }
            while (!board.CheckForWin ());

        }
    }
}