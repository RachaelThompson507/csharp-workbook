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
    class Blocks { }
    /*
    Towers hold blocks, initially Tower A holds all blocks.
    User then moves blocks between 3 towers.
     */
    class Towers { }
    /*
    Creates a game,
    draws the board,
    Allows the user to move blocks
    Allows the user to choose towers.
     */
    class Game { }
}