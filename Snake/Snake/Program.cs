using System;
using System.Collections.Generic;

namespace Snake {
    class Program {
        static void Main() {
            Console.Title = "SNAKE";
            Console.SetWindowSize(86, 30);
            Console.SetBufferSize(86, 30);

            Line left = new Line(LineType.VERTICAL,new Point( 1, 1, '#'),25);
            left.Draw();
            Line right = new Line(LineType.VERTICAL, new Point(84, 1,'#'),25);
            right.Draw();
            Line top = new Line(LineType.HORIZONTAL,new Point(1, 1, '#'),84);
            top.Draw();
            Line down = new Line(LineType.HORIZONTAL, new Point(1, 25,'#'),84);
            down.Draw();
            //Console.WriteLine();
            Snake snake = new Snake(LineType.HORIZONTAL, new Point(6, 6,'*'),3);
            snake.Draw();
            Console.ReadKey();
        }
    }
}
