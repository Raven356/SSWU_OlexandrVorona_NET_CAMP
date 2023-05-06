using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7
{
    internal interface IPrintable
    {
        void Print(int time, IEnumerable<TrafficLight> trafficLights, ITextWorker textWorker);
    }
}
