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
        private double _height;
        private double _width;
        private double _length;
        private List<Box> _boxes;
        private Goods _goods;

        public string Name { get { return _name; } }
        public List<Box> Boxes { get { return _boxes; } }
        public Goods Goods { get { return _goods; } }
        public double Height { get { return _height; } set { _height = value; } }

        public double Width { get => _width; set => _width = value; }
        public double Length { get => _length; set => _length = value; }

        public Box(string name, List<Box> boxes)
        {
            _boxes = boxes;
            _name = name;
        }

        public Box(Goods goods)
        {
            _goods = goods;
            _name = goods.Name;
            _height = goods.Height;
            _width = goods.Width;
            _length = goods.Length;
        }

        public double GetHeightOfSubBoxes()
        {
            double height = 0;
            foreach(var x in _boxes)
            {
                height += x.Height;
            }
            return height;
        }

        public double GetLength()
        {
            return _boxes.Max(x => x.Length);
        }

        public double GetWidth()
        {
            return _boxes.Max(x => x.Width);
        }
    }
}
