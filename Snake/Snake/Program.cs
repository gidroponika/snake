using System;

namespace Snake {
    class Program {
        static void Main() {
            Point p = new Point();
            Move(p, 1, 1);

            Console.WriteLine(p.x);
            Console.WriteLine(p.y);
        }
        static void Move(Point p1,int x,int y) {
            p1.x = x + 1;
            p1.y = y + 1;
        }
    }
}
