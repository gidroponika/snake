using System;
using System.Collections.Generic;
using System.Text;

namespace Snake {
    struct Point {
        public readonly int x;
        public readonly int y;
        char sym;
        public Point(int x,int y,char sym) {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        public void DrawSymbol() {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
