using SnakeGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            //Отрисовка рамочки
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '-');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '-');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, 'I');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, 'I');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            //Отрисoвка точек
            Point p = new Point(4, 5, '*');
            p.Draw();
            Snake snake = new Snake(p, 4, Direction.RIGHT);


            /*Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');

            p2.Draw();

            HorizontalLine line = new HorizontalLine(5,10,8,'+');
            line.Drow();

            Console.ReadLine();*/
        }

    }
}
