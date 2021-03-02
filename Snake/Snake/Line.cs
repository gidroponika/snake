using System;
using System.Collections.Generic;
using System.Text;

namespace Snake {
    enum LineType {
        HORIZONTAL,
        VERTICAL
    }
    class Line :GameObject{
        List<Point> line = new List<Point>();
        public Line(LineType type,int xStart,int yStart,int length,char symbol) 
        {
            //int lineIndex = 0;
            if (type == LineType.HORIZONTAL) {
                for (int i = xStart; i <= length; i++) {
                    line.Add(new Point(i, yStart, symbol));
                    //line[lineIndex++].DrawSymbol();
                }
            }
            else {
                for (int i = yStart; i <= length; i++) {
                    line.Add(new Point(xStart, i, symbol));
                    //line[lineIndex++].DrawSymbol();
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
