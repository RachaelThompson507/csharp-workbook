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
        public Stack<Blocks> fourBlocks {get; set;}
        public Towers (string tower, Stack<Blocks> fourBlocks) {
            this.tower = tower;
            this.fourBlocks = fourBlocks;
        }
    }
    class Game {
        public Dictionary<Towers, Stack<Blocks>> towersForGame {get; private set;}
        
    }
}