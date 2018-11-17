using System;
using System.Collections;
using System.Collections.Generic;

namespace TowersOfHanoi {
    class Program {
        static void Main (string[] args) {
            //enter game
            Console.WriteLine ("Let's Play Tower of Hanoi");
        }
    }
    /*
    Blocks are weighted by number, the greater number = more weight.
    Blocks are interacted with by the user, moved between towers.
    Blocks need to be linked to a tower. 4 needs to be the first block in so 1 can be moved first.
     */
    class Blocks {
        public int block { get; private set; }
        public Blocks (int block) {
            this.block = block;
        }
    }
    /*
    Towers hold blocks, initially Tower A holds all blocks.
    User then moves blocks between 3 towers.
     */
    class Towers {
        public string tower { get; private set; }
        public Stack<Blocks> towerBlocks { get; private set; }
        public Towers (string tower, Stack<Blocks> towerBlocks) {
            this.tower = tower;
            this.towerBlocks = towerBlocks;
        }
        public void InitialBlocks (Blocks block) {
            Blocks four = new Blocks (4);
            Blocks three = new Blocks (3);
            Blocks two = new Blocks (2);
            Blocks one = new Blocks (1);
            towerBlocks.Push (four);
            towerBlocks.Push (three);
            towerBlocks.Push (two);
            towerBlocks.Push (one);
        }
        public void InitialTowers () {
            Towers A = new Towers ("A", towerBlocks);
            Towers B = new Towers ("B", towerBlocks);
            Towers C = new Towers ("C", towerBlocks);
        }

    }
    /*
    Creates a game,
    draws the board,
    Allows the user to move blocks
    Allows the user to choose towers.
     */
    class Game {
        public Dictionary<Towers, Stack<towerBlocks>> TowerBlocks () {
            Dictionary<Towers, Stack<towerBlocks>> towerBlocks = new Dictionary <Towers, Stack<towerBlocks>> ();

        }
    }
}