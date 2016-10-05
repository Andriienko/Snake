using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
    class GLine:Figure
    {   
        public GLine(int x_left, int x_right, int y, char sym)
        {
            list = new List<Point>();
            for (int x = x_left; x <= x_right; ++x)
            {
                Point p = new Point(x, y, sym);
                list.Add(p);
            }
        }
    }
}
