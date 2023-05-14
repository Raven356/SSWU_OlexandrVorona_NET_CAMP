using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8
{
    internal class OneDirectionalTrafficLight : AbstractTrafficLight
    {
        public OneDirectionalTrafficLight(string direction, Color currentColor) : base(direction, currentColor)
        {
        }
    }
}
