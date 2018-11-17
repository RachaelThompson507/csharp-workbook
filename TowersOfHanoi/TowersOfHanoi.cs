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
        String moveTo = "";
        String moved = "";
        //game constructor
        public Game () {
            //make towers for dictionary
            MakeTowers["A"] = new Towers();
            MakeTowers["B"] = new Towers();
            MakeTowers["C"] = new Towers();
            //make blocks for the towers
            Blocks block1 = new Blocks(1);
            Blocks block2 = new Blocks(2);
            Blocks block3 = new Blocks(3);
            Blocks block4 = new Blocks(4);
            //add blocks to tower A for the initial start of the game
            MakeTowers["A"].towerBlocks.Push(block4);
            MakeTowers["A"].towerBlocks.Push(block3);
            MakeTowers["A"].towerBlocks.Push(block2);
            MakeTowers["A"].towerBlocks.Push(block1);
        }

        public void PlaceMove () {
            Console.WriteLine ("Where would you like to place your move?");
            string userChoice = Console.ReadLine ();
        }

    }
}