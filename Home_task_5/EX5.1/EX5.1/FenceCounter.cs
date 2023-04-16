using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
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

        public double FindShortestFence()
        {
            List<Point> hull = Jarvis();
            double length = 0;
            for(int i = 0; i < hull.Count - 1; i++)
            {
                length += Math.Sqrt(Math.Pow(hull[i].X - hull[i + 1].X, 2) + Math.Pow(hull[i].Y - hull[i + 1].Y, 2));
            }
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

        private List<Point> Jarvis()
        {
            List<Point> points = new List<Point>();
            points.Add(_points[0]);
            Point current = _points.Where(point => point.X == _points.Min(x => x.X)).First();
            Point endPoint;
            do
            {
                points.Add(current);
                endPoint = _points[0];

                for(int i = 1; i < _points.Count; i++)
                {
                    if(current == endPoint || Position(current, endPoint, _points[i]) == -1)
                    {
                        endPoint = _points[i];
                    }
                }
                current = endPoint;
            }
            while (current != _points[0]);
            points = points.Distinct().ToList();
            points.Add(_points[0]);
            return points;
        }

        private int Position(Point p1, Point p2, Point p)
        {
            int pos = (p2.X - p1.X) * (p.Y - p1.Y) - (p.X - p1.X) * (p2.Y - p1.Y);
            if(pos < 0)
            {
                return 1;
            }
            if(pos > 0)
            {
                return -1;
            }
            return 0;
        }



        public double FindSquare()
        {
            List<Point> points = Jarvis();
            List<List<Point>> trianges = new List<List<Point>>();
            for(int i = 0; i < points.Count; i ++)
            {
                if (i % 3 == 0)
                {
                    trianges.Add(new List<Point>());
                }
                if(i % 3 == 0 && i != 0)
                    trianges[trianges.Count - 1].Add(points[i - 1]);
                trianges[trianges.Count - 1].Add(points[i]);
            }
            double square = 0;
            for(int i = 0; i < trianges.Count; i++)
            {
                double first = Math.Sqrt(Math.Pow(trianges[i][0].X - trianges[i][1].X, 2) + Math.Pow(trianges[i][0].Y - trianges[i][1].Y, 2));
                double second = Math.Sqrt(Math.Pow(trianges[i][0].X - trianges[i][2].X, 2) + Math.Pow(trianges[i][0].Y - trianges[i][2].Y, 2));
                double third = Math.Sqrt(Math.Pow(trianges[i][1].X - trianges[i][2].X, 2) + Math.Pow(trianges[i][1].Y - trianges[i][2].Y, 2));
                double halfPerimeter = (first + second + third) / 2;
                square += Math.Sqrt(halfPerimeter * (halfPerimeter - first) * (halfPerimeter - second) * (halfPerimeter - third));
            }
            return square;
        }
    }
}
