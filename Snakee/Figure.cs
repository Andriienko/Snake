using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
    class Figure
    {
        protected List<Point> list;
        virtual public void Draw()
        {
            foreach (Point i in list)
            {
                i.Draw();
            }
        }
        internal bool IsHit(Figure figure)
        {
            foreach (var i in list)
            {
                if (figure.IsHit(i))
                    return true;
            }
            return false;
        }
        private bool IsHit(Point point)
        {
            foreach (var i in list)
            {
                if (i.IsHit(point))
                    return true;
            }
            return false;
        }

    }
}
