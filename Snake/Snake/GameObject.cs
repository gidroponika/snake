using System;
using System.Collections.Generic;
using System.Text;

namespace Snake {
    class GameObject {
        public int X { get; protected set; }
        public int Y { get; protected set; }
        public char Sym { get; protected set; }
        protected GameObject() { }
        public GameObject(int xPos, int yPos, char symbol) {
            X = xPos;
            Y = yPos;
            Sym = symbol;
        }
        public virtual void Draw() {
            Console.SetCursorPosition(X, Y);
            Console.Write(Sym);
        }
        public virtual void Move(int offset, Direction dir) {
            if (dir == Direction.LEFT) {
                X -= offset;
            }
            else if (dir == Direction.RIGHT) {
                X += offset;
            }
            else if (dir == Direction.UP) {
                Y -= offset;
            }
            else if (dir == Direction.DOWN) {
                Y += offset;
            }
        }
    }
}
