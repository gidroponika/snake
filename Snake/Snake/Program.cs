using System;

namespace Snake {
    class Program {
        static void Main() {
            Point point = new Point(4, 3, 'x');
            point.DrawSymbol();
            Console.WriteLine();
        }
    }
}
