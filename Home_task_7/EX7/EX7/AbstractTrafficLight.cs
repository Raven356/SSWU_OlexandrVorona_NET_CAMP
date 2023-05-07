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

    internal abstract class AbstractTrafficLight
    {
        protected string _name;
        protected Color _color;

        public string Name { get => _name; }
        public Color LightColor { get => _color; }

        public abstract void ChangeColor();
        public AbstractTrafficLight(Color color, string name)
        {
            _color = color;
            _name = name;
        }

        public override string? ToString()
        {
            return $"Name: {_name} Color: {_color}";
        }
    }
}
