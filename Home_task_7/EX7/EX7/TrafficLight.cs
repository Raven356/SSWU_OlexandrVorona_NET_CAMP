using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7
{
    enum Color
    {
        Red,
        RedYellow,
        Green,
        Yellow
    }
    internal class TrafficLight
    {
        private string _name;
        private Color _color;
        public TrafficLight(Color color, string name)
        {
            _color = color;
            _name = name;
        }

        public string Name { get => _name; }
        internal Color LightColor { get => _color; }

        public void ChangeColor()
        {
            if(_color == Color.Yellow)
            {
                _color = Color.Red;
                return;
            }
            _color++;
        }

        public override string? ToString()
        {
            return $"Name: {_name} Color: {_color}";
        }
    }
}
