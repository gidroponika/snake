using System;
using System.Collections.Generic;
using System.Text;

namespace Snake {
    class GameObject {
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public char Sym { get; protected set; }
        protected GameObject() { }
        public GameObject(int x, int y, char sym) {
            X = x;
            Y = y;
            Sym = sym;
        }
        public virtual void DrawSymbol() {
            Console.SetCursorPosition(X, Y);
            Console.Write(Sym);
        }
    }
}
