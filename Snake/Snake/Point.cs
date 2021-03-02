using System;
using System.Collections.Generic;
using System.Text;

namespace Snake {
    class Point : GameObject{
        public Point(int xPos, int yPos, char symbol) :
            base (xPos,yPos,symbol)
        {
        }
    }
}
