using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Snake {
    class Snake :Line{
        public Snake(LineType direction, Point startPoint,int length):
            base (direction, startPoint,length)
        {
            line.RemoveAt(line.Count - 1);
            if (direction == LineType.HORIZONTAL) {
                line.Add(new Point(startPoint.X + length-1, startPoint.Y, '@'));
            }
            else {
                line.Add(new Point(startPoint.X, startPoint.Y + length - 1, '@'));
            }
            line.Reverse();
        }
        public void Move() {
            Point head = line.First();
        }
    }
}
