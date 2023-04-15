using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5._1
{
    internal class FenceCounter
    {
        private List<Point> _points;

        public FenceCounter(List<Point> points)
        {
            _points = points;
            
            _points.Sort(new PointComparer());
        }

        public int FindShortestFence()
        {
            int length = 0;
            for(int i = 1; i < _points.Count; i++)
            {
                length += (int)Math.Sqrt(Math.Pow(_points[i].X - _points[i-1].X, 2) + Math.Pow(_points[i].Y - _points[i - 1].Y, 2));
            }
            length += (int)Math.Sqrt(Math.Pow(_points[_points.Count - 1].X - _points[0].X, 2) + Math.Pow(_points[_points.Count - 1].Y - _points[0].Y, 2));
            return length;
        }

        public static bool operator >(FenceCounter x, FenceCounter y)
        {
            return x.FindShortestFence() > y.FindShortestFence();
        }

        public static bool operator <(FenceCounter x, FenceCounter y)
        {
            return x.FindShortestFence() < y.FindShortestFence();
        }

        //public double FindSquare()
        //{
        //    double square = 0;
        //    for(int i = 1; i < _points.Count; i++)
        //    {
        //        if (_points[i].X != _points[i - 1].X && _points[i].Y != _points[i - 1].Y)
        //        {
        //            square += (MathF.Abs(_points[i].X - _points[i - 1].X) * MathF.Abs(_points[i].Y - _points[i - 1].Y)) / 2;
        //        }
        //    }
        //    return square;
        //}
    }
}
