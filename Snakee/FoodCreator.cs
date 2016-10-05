using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakee
{
    class FoodCreator
    {
         int WindowHeight;
         int WindowWidth;
         char sym;

         Random random = new Random();
         public FoodCreator(int windW, int windH, char sym)
         {
             WindowHeight = windH;
             WindowWidth = windW;
             this.sym = sym;
         }
         public Point CreateFood()
         {
             int x = random.Next(2, WindowWidth - 2);
             int y = random.Next(2, WindowHeight - 2);
             return new Point(x,y,sym);
         }
    }
}
