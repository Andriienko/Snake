using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
    class Snake : Figure
    {
        Direction direct;
        public Snake(Point pos, int length, Direction _direct)
        {
            direct = _direct;
            list = new List<Point>();
            for (int i=0; i<length; ++i)
            {
                Point p = new Point(pos);
                p.Move(i,_direct);
                list.Add(p);
            }
        }
        public void Move()
        {
            Point tail = list.First();
            list.Remove(tail);
            Point head = GetNext();
            list.Add(head);
            tail.Clear();
            head.Draw();
        }
        public Point GetNext()
        {
            Point head = list.Last();
            Point next = new Point(head);
            next.Move(1, direct);
            return next;
        }
        public void Handlekey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                    direct = Direction.LEFT;
            if (key == ConsoleKey.RightArrow)
                direct = Direction.RIGHT;
            if (key == ConsoleKey.UpArrow)
                direct = Direction.UP;
            if (key == ConsoleKey.DownArrow)
                direct = Direction.DOWN;
       }
        public bool Eat(Point food)
        {
            Point head = GetNext();
            if (head.IsEat(food))
            {
                food.sym = head.sym;
                food.Draw();
                list.Add(food);
                return true;
            }
            else
                return false;
        }
        public bool IsTailHit()
        {
            Point head;
            head=GetNext();
            for (int i = 0; i < list.Count - 2; ++i)
            {
                if (head.IsHit(list[i]))
                    return true;
            }
            return false;
        }

    }
}
