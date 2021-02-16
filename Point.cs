using System;

namespace SnakeGame
{
    internal class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;



        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y); //SetCursorPosition - начальная точка курсора
            Console.Write(sym);

        }
    }
}