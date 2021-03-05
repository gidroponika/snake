using System;
using System.Collections.Generic;
using System.Text;

namespace Snake {
    enum LineType {
        HORIZONTAL,
        VERTICAL
    }
    class Line :GameObject{
        protected List<Point> line = new List<Point>();
        public Line(LineType type,Point startPoint,int length) :
            base(startPoint.X, startPoint.Y, startPoint.Sym)
        {
            if (type == LineType.HORIZONTAL) {
                for (int i = startPoint.X; i < length+ startPoint.X; i++) {
                    line.Add(new Point(i, startPoint.Y, startPoint.Sym));
                }
            }
            else {
                for (int i = startPoint.Y; i < length+ startPoint.Y; i++) {
                    line.Add(new Point(startPoint.X, i, startPoint.Sym));
                }
            }
        }
        public override void Draw() {
            foreach(GameObject obj in line) {
                obj.Draw();
            }
        }
    }
}
