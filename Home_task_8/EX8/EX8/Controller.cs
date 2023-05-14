using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8
{
    internal static class Controller
    {
        private static List<Crossroad> _crossroads = new List<Crossroad>();

        public static List<Crossroad> Crossroads { get { return new List<Crossroad> (_crossroads); } set {_crossroads = new List<Crossroad>(value); } }

        public static void CheckState(int timerState)
        {
            Color color;
            foreach(Crossroad crossroad in _crossroads)
            {
                color = crossroad.Lights[0].CurrentColor;
                bool containsSideLight = false;
                foreach(var light in crossroad.Lights)
                {
                    if(light is TwoDirectionalTrafficLight)
                    {
                        containsSideLight = true;
                        break;
                    }
                }
                if (timerState % crossroad.Timings[(int)color] == 0)
                {
                    crossroad.RaiseChangeColorEvent();
                }
                if (containsSideLight)
                {
                    if (timerState % crossroad.Timings[2] == 0)
                    {
                        crossroad.RaiseChangeSideColorEvent();
                    }
                }
            }
        }

        public static void AddCrossroad(Crossroad crossroad)
        {
            _crossroads.Add(crossroad);
        }

        public static void AddTrafficLight(AbstractTrafficLight trafficLight, int index)
        {
            _crossroads[index].AddTrafficLight(trafficLight);
        }
    }
}
