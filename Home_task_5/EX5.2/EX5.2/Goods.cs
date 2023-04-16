using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5._2
{
    internal class Goods
    {
        private double _size;
        private string _name;
        public double Size { get { return _size; } }
        public string Name { get { return _name; } }
        public Goods(double size, string name)
        {
            _size = size;
            _name = name;
        }
    }
}
