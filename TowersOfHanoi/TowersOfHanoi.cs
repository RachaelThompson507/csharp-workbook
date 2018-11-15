using System;
using System.Collections;
using System.Collections.Generic;

namespace TowersOfHanoi {
    class Program {
        static void Main (string[] args) {
            //declare variables
            //enter game
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
        Blocks block1 = new Blocks (4);
        Blocks block2 = new Blocks (3);
        Blocks block3 = new Blocks (2);
        Blocks block4 = new Blocks (1);
        public Stack<Blocks> StackBlocks { get; set; }
        public Towers (string tower, Stack<Blocks> StackBlocks) {
            this.tower = tower;
            this.StackBlocks = StackBlocks;
            StackBlocks.Push(block4);
            StackBlocks.Push(block3);
            StackBlocks.Push(block2);
            StackBlocks.Push(block1);
        }
    }
    //has the user input and creation of the game
    class Game {
        public Dictionary<Towers, Stack<Blocks>> towersForGame { get; private set; }
        //Towers towerA = new Towers ("A");
        public Game (Dictionary <Towers, Stack<Blocks>> towersForGame) {
            this.towersForGame = towersForGame;

        }

    }
}