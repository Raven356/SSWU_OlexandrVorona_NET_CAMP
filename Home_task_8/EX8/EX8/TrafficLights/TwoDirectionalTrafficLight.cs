using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8
{
    internal class TwoDirectionalTrafficLight : AbstractTrafficLight
    {
        private bool _isSecondDirectionEnabled = false;
        private string _sideDirection;

        public TwoDirectionalTrafficLight(string direction, string sideDirection, Color currentColor, bool isSecondDirectionEnabled) : base(direction, currentColor)
        {
            _isSecondDirectionEnabled = isSecondDirectionEnabled;
            _sideDirection = sideDirection;
        }

        public string SideDirection { get => _sideDirection; }

        public bool IsSideDirectionEnabled {  get => _isSecondDirectionEnabled; }

        public void ChangeSecondDirection()
        {
            _isSecondDirectionEnabled = !_isSecondDirectionEnabled;
        }
    }
}
