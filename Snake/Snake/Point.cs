using System;
using System.Collections.Generic;
using System.Text;

namespace Snake {
    enum Direction {
        LEFT,
        RIGHT,
        UP,
        DOWN
    }
    class Point : GameObject{
        public Point(int xPos, int yPos, char symbol) :
            base (xPos,yPos,symbol)
        {}
    }
}
