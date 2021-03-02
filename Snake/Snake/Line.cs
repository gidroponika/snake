using System;
using System.Collections.Generic;
using System.Text;

namespace Snake {
    enum LineType {
        HORIZONTAL,
        VERTICAL
    }
    class HorizontalLine :GameObject{
        List<GameObject> line = new List<GameObject>();

        public HorizontalLine(int xStart,int yStart,
                              int endDirection,char symbol) 
        {
            int lineIndex = 0;
            for (int i = xStart; i <= endDirection; i++) {
                line.Add(new GameObject(i, yStart, symbol));
                line[lineIndex++].DrawSymbol();
            }
        }
    }
    class VerticalLine : GameObject {
        List<GameObject> line = new List<GameObject>();
        public VerticalLine(int xStart, int yStart,
                            int endDirection, char symbol)
        {
            int lineIndex = 0;
            for(int i = yStart; i <= endDirection; i++) {
                line.Add(new GameObject(xStart, i, symbol));
                line[lineIndex++].DrawSymbol();
            }
        }
    }
    class Line {
        List<GameObject> line = new List<GameObject>();
        public Line(LineType type,int xStart,int yStart,int length,
                    char symbol) 
        {
            int lineIndex = 0;
            if (type == LineType.HORIZONTAL) {
                for (int i = xStart; i <= length; i++) {
                    line.Add(new GameObject(i, yStart, symbol));
                    line[lineIndex++].DrawSymbol();
                }
            }
            else {
                for (int i = yStart; i <= length; i++) {
                    line.Add(new GameObject(xStart, i, symbol));
                    line[lineIndex++].DrawSymbol();
                }
            }
        }
    }
}
