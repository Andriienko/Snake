using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
    class Wall:Figure
    {
        List<Figure> wallList;

        public Wall(int w, int h)
        {
            wallList = new List<Figure>();
            VLine Right = new VLine(0, h-1, w-2, '*');
            VLine Left = new VLine(0, h-1, 0, '*');
            GLine Up = new GLine(0, w-2, 0, '+');
            GLine Down = new GLine(0, w-2, h-1, '+');

            wallList.Add(Right);
            wallList.Add(Left);
            wallList.Add(Up);
            wallList.Add(Down);
        }
        override public void Draw()
        {
            foreach (Figure i in wallList)
            {
                i.Draw();
            }
        }
       internal bool IsHit(Figure figure)
        {
            foreach (var i in wallList)
            {
                if (i.IsHit(figure))
                    return true;
             }
            return false;
        }
    }
}
