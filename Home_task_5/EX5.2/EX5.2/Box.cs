using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5._2
{
    internal class Box
    {
        private string _name;
        private double _size;
        private List<Box> _boxes;
        private Goods _goods;

        public string Name { get { return _name; } }
        public List<Box> Boxes { get { return _boxes; } }
        public Goods Goods { get { return _goods; } }
        public double Size { get { return _size; } set { _size = value; } }

        public Box(string name, List<Box> boxes)
        {
            _boxes = boxes;
            _name = name;
        }

        public Box(Goods goods)
        {
            _goods = goods;
            _name = goods.Name;
            _size = goods.Size;
        }

        public double GetSizeOfSubBoxes()
        {
            double size = 0;
            foreach(var x in _boxes)
            {
                size += x.Size;
            }
            return size;
        }
    }
}
