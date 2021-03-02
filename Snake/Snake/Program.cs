using System;
using System.Collections.Generic;

namespace Snake {
    class Program {
        static void Main() {
            Line top = new Line(LineType.HORIZONTAL, 1, 1, 50, '#');
            Line down = new Line(LineType.HORIZONTAL, 1, 25, 50, '#');
            Line left = new Line(LineType.VERTICAL, 1, 1, 25, '#');
            Line right = new Line(LineType.VERTICAL, 50, 1, 25, '#');
            Console.WriteLine();
        }
    }
}
