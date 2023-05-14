using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8
{
    internal abstract class AbstractTrafficLight : ITrafficLight
    {
        protected string _direction;
        protected Color _currentColor;
        protected Color _previousColor;

        public string Direction { get { return _direction; } }

        public Color CurrentColor { get { return _currentColor; } }


        public AbstractTrafficLight(string direction, Color currentColor)
        {
            _direction = direction;
            _currentColor = currentColor;
        }

        public virtual void ChangeColor()
        {

            if (CurrentColor.Equals(Color.Green) || CurrentColor.Equals(Color.Red))
            {
                _previousColor = _currentColor;
                _currentColor = Color.Yellow;
            }
            else if (CurrentColor.Equals(Color.Yellow) && _previousColor.Equals(Color.Red))
            {
                _previousColor = _currentColor;
                _currentColor = Color.Green;
            }
            else
            {
                _previousColor = _currentColor;
                _currentColor = Color.Red;
            }


        }

    }
}
