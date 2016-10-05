using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point() { }
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public Point(Point tail)
        {
            x = tail.x;
            y = tail.y;
            sym = tail.sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Move(int n,Direction direct)
        {
            if (direct == Direction.RIGHT)
                x += n;
            else if (direct == Direction.LEFT)
                x -= n;
            else if (direct == Direction.UP)
                y -= n;
            else
                y += n;
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }
        public bool IsEat(Point food)
        {
            if ((x == food.x) && (y == food.y))
                return true;
            else 
                return false;
        }
        public bool IsHit(Point p)
        {
            if ((x == p.x)&&(y == p.y))
                return true;
            else
                return false;
        }
    }
}
