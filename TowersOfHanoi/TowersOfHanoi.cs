using System;
using System.Collections;
using System.Collections.Generic;

namespace TowersOfHanoi {
    class Program {
        static void Main (string[] args) {
            //declare variables
            Dictionary<Towers, Stack<Blocks>> towersForGame = new Dictionary <Towers, Stack<Blocks>> ();
            //enter game
            Console.WriteLine ("Let's Play Tower of Hanoi");
            Game newgame = new Game (towersForGame);
        }
    }
    //blocks are numbers that are used to move between towers
    class Blocks {
        public int block { get; private set; }

        public Blocks (int block) {
            this.block = block;
        }
    }
    //towers are "holders" of the blocks and keep them in order of largest - smallest LIFO
    class Towers {
        public string tower { get; private set; }
        
        public Towers A = new Towers ("A", AStackBlocks);
        public Towers B = new Towers ("B", BStackBlocks);
        public static Stack<Blocks> AStackBlocks { get; set; }
        public static Stack<Blocks> BStackBlocks { get; set; }
        public static Stack<Blocks> CStackBlocks { get; set; }
        public Towers (string tower, Stack<Blocks> StackOfBlocks) {
            this.tower = tower;
        }
        public void addBlocks() {
            Blocks block1 = new Blocks (4);
            Blocks block2 = new Blocks (3);
            Blocks block3 = new Blocks (2);
            Blocks block4 = new Blocks (1);
            
        }
    }
    //has the user input and creation of the game
    class Game {
        // public Dictionary<Towers, Stack<Blocks>> towersForGame { get; private set; }
        //Make Towers- Add StackBlocks to Tower Keys in Dictionary
        // Towers A = new Towers ("A", Stack<Blocks> StackBlocks);
        public Game (Dictionary <Towers, Stack<Blocks>> towersForGame) {
            this.towersForGame = towersForGame;

        }

    }
}