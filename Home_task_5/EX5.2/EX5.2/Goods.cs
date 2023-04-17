using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5._2
{
    internal class Goods
    {
        private double _height;
        private double _width;
        private double _length;
        private string _name;
        public double Height { get { return _height; } }
        public string Name { get { return _name; } }

        public double Width { get => _width; set => _width = value; }
        public double Length { get => _length; set => _length = value; }

        public Goods(double height, double length, double width, string name)
        {
            _height = height;
            _width = width;
            _length = length;
            _name = name;
        }
    }
}
