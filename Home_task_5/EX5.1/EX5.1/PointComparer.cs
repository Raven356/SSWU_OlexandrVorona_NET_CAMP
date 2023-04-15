using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5._1
{
    internal class PointComparer : IComparer<Point>
    {
        public int Compare(Point x, Point y)
        {
            if(x.X == y.X && x.Y == y.Y)
                return 0;
            if(x.X < y.X || (x.X == y.X && x.Y < y.Y))
                return -1;
            return 1;
        }
    }
}
