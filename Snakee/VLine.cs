using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
    class VLine:Figure
    {
        public VLine(int y_up, int y_down, int x, char sym)
        {
            list = new List<Point>();
            for (int y = y_up; y <= y_down; ++y)
            {
                Point t = new Point(x, y, sym);
                list.Add(t);
            }
        }
     }
}
