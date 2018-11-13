using System;
using System.Collections;
using System.Collections.Generic;

namespace TowersOfHanoi {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Let's Play Tower of Hanoi");
        }
    }
    class Blocks {
        public int block {get; private set;}
        
        public Blocks (int block) {
            this.block = block;
        }
    }
    class Towers {
        public string tower { get; private set;}
        public Stack<Blocks> blocks4 {get; private set;}
        public Towers (string tower, Stack<Blocks> blocks4) {
            this.tower = tower;
            this.blocks4 = blocks4;
        }
    }
    class Game {
        public Dictionary<Towers, Blocks> gameTowersBlocks {get; private set;}
        

    }
}