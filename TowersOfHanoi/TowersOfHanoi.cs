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
        public string block {get; private set;}
        //do I need to specify the number of blocks
        //public int numBlocks {get; private set;}
        public Stack<string> ofBlocks {get; private set;}
        public Blocks (string block, Stack<string> ofBlocks) {
            this.block = block;
            //how to create a stack of blocks
            //this.ofBlocks = new ;
        }
    }
    class Towers {
        public string tower { get; private set;}
        public Towers (string tower) {
            this.tower = tower;
        }
    }
    class Game {


    }
}