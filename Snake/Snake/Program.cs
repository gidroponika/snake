using System;
using System.Collections.Generic;

namespace Snake {
    class Program {
        static void Main() {
            Console.Title = "SNAKE";
            Console.SetWindowSize(86, 26);
            Console.SetBufferSize(86, 26);

            Line left = new Line(LineType.VERTICAL, 1, 1, 25, '#');
            left.Draw();
            Line right = new Line(LineType.VERTICAL, 85, 1, 25, '#');
            right.Draw();
            Line top = new Line(LineType.HORIZONTAL, 1, 1, 85, '#');
            top.Draw();
            Line down = new Line(LineType.HORIZONTAL, 1, 25, 85, '#');
            down.Draw();
        }
    }
}
