using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7
{
    internal class PrintAnswer : IPrintable
    {

        public void Print(int time, IEnumerable<TrafficLight> trafficLights, ITextWorker textWorker)
        {
            textWorker.Print("Time: " + time + "s ");
            foreach (TrafficLight light in trafficLights)
            {
                IEnumerable<TrafficLight> lines = trafficLights.Where(l => l.LightColor.Equals(light.LightColor));
                StringBuilder sb = new StringBuilder();
                sb.Append(light.Name + "-");
                foreach (TrafficLight l in lines)
                {
                    if (!sb.ToString().Contains(l.Name + "-"))
                        sb.Append(l.Name + "-");
                }
                sb.Remove(sb.Length - 1, 1);
                textWorker.Print("Name: " + sb.ToString() + " Color: " + light.LightColor + " ");
            }
            textWorker.PrintLine("");
        }
    }
}
