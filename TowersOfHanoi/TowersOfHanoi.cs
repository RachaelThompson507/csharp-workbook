using System;
using System.Collections;
using System.Collections.Generic;

namespace TowersOfHanoi {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Let's Play Tower of Hanoi");
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
        public Stack<Blocks> fourBlocks { get; set; }
        public Towers (string tower, Stack<Blocks> fourBlocks) {
            this.tower = tower;
            this.fourBlocks = fourBlocks;
        }
    }
    //has the user input and creation of the game
    class Game {
        public Dictionary<Towers, Stack<Blocks>> towersForGame { get; private set; }

    }
}