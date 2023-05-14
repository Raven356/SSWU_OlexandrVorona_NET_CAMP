using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8
{
    internal class Crossroad
    {
        private uint[] _timings;

        public uint[] Timings { get { return (uint[])_timings.Clone(); } }

        private List<AbstractTrafficLight> _lights = new List<AbstractTrafficLight>();

        public List<AbstractTrafficLight> Lights { get { return new List<AbstractTrafficLight> (_lights); } }

        private event Action ChangeColor;
        private event Action ChangeSideColor;

        public Crossroad(uint[] timings, List<AbstractTrafficLight> lights)
        {
            _timings = (uint[])timings.Clone();
            _lights = new List<AbstractTrafficLight>(lights);
            AddEventsOnChangeColor();
        }

        public Crossroad(uint[] timings) {
            _timings = (uint[]) timings.Clone();
        }

        public void AddTrafficLight(AbstractTrafficLight light)
        {
            _lights.Add(light);
            ChangeColor += light.ChangeColor;
            if (light is TwoDirectionalTrafficLight)
                ChangeSideColor += (light as TwoDirectionalTrafficLight).ChangeSecondDirection;
        }

        private void AddEventsOnChangeColor()
        {
            foreach(var light in _lights)
            {
                ChangeColor += light.ChangeColor;
                if (light is TwoDirectionalTrafficLight)
                    ChangeSideColor += (light as TwoDirectionalTrafficLight).ChangeSecondDirection;
            }
        }

        public void RaiseChangeColorEvent()
        {
            ChangeColor.Invoke();
        }

        public void RaiseChangeSideColorEvent()
        {
            ChangeSideColor.Invoke();
        }

        
    }
}
