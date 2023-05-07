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
    internal class TrafficLight : AbstractTrafficLight
    {

        public TrafficLight(Color color, string name) : base(color, name)
        {

        }

        public override void ChangeColor()
        {
            if(_color == Color.Yellow)
            {
                _color = Color.Red;
                return;
            }
            _color++;
        }


    }
}
