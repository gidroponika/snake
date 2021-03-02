using System;
using System.Collections.Generic;
using System.Text;

namespace Snake {
    class Point : GameObject{
        public Point(int x, int y, char sym) :
            base (x,y,sym)
        {}
    }
}
