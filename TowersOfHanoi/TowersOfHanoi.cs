using System;
using System.Collections;
using System.Collections.Generic;

namespace TowersOfHanoi {
    class Program {
        static void Main (string[] args) {
            //enter game
            Console.WriteLine ("Let's Play Tower of Hanoi");
            Game towerOfHanoiGame = new Game ();
            towerOfHanoiGame.Play ();
        }
    }
    /*
    Blocks are weighted by number, the greater number = more weight.
    Blocks are interacted with by the user, moved between towers.
    Blocks need to be linked to a tower. 4 needs to be the first block in so 1 can be moved first.
     */
    class Blocks {
        public int weightedBlock { get; set; }
        public Blocks (int weightedBlock) {
            this.weightedBlock = weightedBlock;
        }
    }
    /*
    Towers hold blocks, initially Tower A holds all blocks.
    User then moves blocks between 3 towers.
     */
    class Towers {
        public Stack<Blocks> towerBlocks { get; set; }
        public Towers () {
            this.towerBlocks = new Stack<Blocks> ();
        }

    }
    /*
    Creates a game,
    draws the board,
    Allows the user to move blocks
    Allows the user to choose towers.
     */
    class Game {
        //variables &&|| definitions
        Dictionary<String, Towers> MakeTowers = new Dictionary<String, Towers> ();
        bool win = false;
        string userChoice1 = "";
        String moveFrom = "";
        String userChoice2 = "";
        String movedTo = "";
        //game constructor
        public Game () {
            //make towers for dictionary
            MakeTowers["A"] = new Towers ();
            MakeTowers["B"] = new Towers ();
            MakeTowers["C"] = new Towers ();
            //make blocks for the towers
            Blocks block1 = new Blocks (1);
            Blocks block2 = new Blocks (2);
            Blocks block3 = new Blocks (3);
            Blocks block4 = new Blocks (4);
            //add blocks to tower A for the initial start of the game
            MakeTowers["A"].towerBlocks.Push (block4);
            MakeTowers["A"].towerBlocks.Push (block3);
            MakeTowers["A"].towerBlocks.Push (block2);
            MakeTowers["A"].towerBlocks.Push (block1);
        }
        //creates the board to play with- uses stacks for blocks and dictionary of Towers for towers
        public void PrintBoard () {
            foreach (String name in MakeTowers.Keys) {
                Console.WriteLine ();
                Console.Write (name + ": ");
                Towers tower = MakeTowers[name];
                Stack<Blocks> stackOfBlocks = tower.towerBlocks;
                Stack<Blocks> stackPrinted = new Stack<Blocks> ();

                //another foreach for blocks - to make sure that they are in order when printed
                foreach (Blocks b in stackOfBlocks) {
                    stackPrinted.Push (b);
                }
                //another foreach loop for weighted distribution
                foreach (Blocks z in stackPrinted) {
                    Console.Write (z.weightedBlock);
                }
                Console.WriteLine ();
            }
        }
        //This is what the user chooses to move from.
        public string UserMoveFrom () {
            Console.WriteLine ();
            Console.WriteLine ("What tower are you moving your block from? Choose 'A'  'B' or 'C' ");
            userChoice1 = Console.ReadLine ().ToUpper ().Trim ();
            //Console.WriteLine ();
            return userChoice1;
        }
        //validates choice
        public void ValidMoveFrom (string userChoice1) {
            if ((userChoice1 == "A") || (userChoice1 == "B") || (userChoice1 == "C")) {
                moveFrom = userChoice1;
            } else {
                throw new Exception ("Sorry, that input is invalid.");
            }
        }
        //This is what user chooses to move to.
        public string UserMoveTo () {
            Console.WriteLine ("What tower are you moving your block to? Choose 'A'  'B' or 'C' ");
            userChoice2 = Console.ReadLine ().ToUpper ().Trim ();
            //Console.WriteLine ();
            return userChoice2;
        }
        //validates choice
        public void ValidMoveTo (string userChoice2) {
            if ((userChoice2 == "A") || (userChoice2 == "B") || (userChoice2 == "C")) {
                movedTo = userChoice2;
            } else {
                throw new Exception ("Sorry, that input is invalid.");
            }
        }
        public void MoveBlock () {
            //checks to see if from is empty
            if (MakeTowers[moveFrom].towerBlocks.Count == 0) {
                throw new Exception ("You are trying to move from a tower that does not contain blocks.");
            }
            var MovingPiece = MakeTowers[moveFrom].towerBlocks.Peek ();
            //check for moved To if empty
            if (MakeTowers[movedTo].towerBlocks.Count == 0) {
                MakeTowers[moveFrom].towerBlocks.Pop ();
                MakeTowers[movedTo].towerBlocks.Push (MovingPiece);
                //check if block in moved to is bigger
            } else if (MakeTowers[movedTo].towerBlocks.Peek ().weightedBlock > MovingPiece.weightedBlock) {
                MakeTowers[moveFrom].towerBlocks.Pop ();
                MakeTowers[movedTo].towerBlocks.Push (MovingPiece);
            } else {
                throw new Exception ("You are trying to move a bigger block onto a smaller one, this is not valid.");
            }

        }
        //time to check for a win
        public void CheckForWin () {
            if (MakeTowers["C"].towerBlocks.Count >= 4) {
                Console.WriteLine ("You Win!");
                win = true;
            } else if (MakeTowers["B"].towerBlocks.Count >= 4) {
                Console.WriteLine ("You Win!");
                win = true;
            } else {
                win = false;
            }
        }
        //time to play the game
        public void Play () {
            while (!win) {
                TryAgain : PrintBoard ();
                UserMoveFrom ();
                try {
                    ValidMoveFrom (userChoice1);
                } catch (Exception) {
                    Console.WriteLine ("Sorry, that input is invalid. Please try again.");
                    Console.WriteLine ();
                    UserMoveFrom ();
                }
                UserMoveTo ();
                try {
                    ValidMoveTo (userChoice2);
                } catch (Exception) {
                    Console.WriteLine ("Sorry, that input is invalid. Please try again.");
                    Console.WriteLine ();
                    UserMoveTo ();
                }
                try {
                    MoveBlock ();
                } catch (Exception) {
                    Console.WriteLine ("You either tried to:\n A- move a block from an empty tower \nor \n B- tried to place a bigger block on a smaller one. \nTry another move.");
                    Console.WriteLine ();
                    goto TryAgain;
                }
                CheckForWin ();
            }
        }
    }
}