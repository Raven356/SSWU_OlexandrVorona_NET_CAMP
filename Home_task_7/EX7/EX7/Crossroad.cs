using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EX7
{
    internal class Crossroad
    {
        public event Action changeColor;
        private int _endTime;
        private List<TrafficLight> _lights = new List<TrafficLight>();
        private System.Timers.Timer _timer;
        private int _current;
        private IPrintable _printResult;
        private ITextWorker _textWorker;

        public bool IsTimerEnabled
        {
            get { return _timer.Enabled; }
        }

        public Crossroad(int interval, int endTime, IPrintable printable, List<TrafficLight> trafficLights, ITextWorker textWorker)
        {
            _textWorker = textWorker;
            _printResult = printable;
            _endTime = endTime;
            _lights = trafficLights.ToList();
            foreach(TrafficLight light in _lights)
            {
                changeColor += light.ChangeColor;
            }
            _timer = new System.Timers.Timer(interval);
            _timer.Elapsed += OnTimerElapsed;
            _timer.Start();
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            int interval = (int)_timer.Interval;
            if (_current > _endTime || _current +  interval > _endTime)
            {
                _timer.Stop();
                return;
            }
            else
            {
                changeColor?.Invoke();
                _printResult.Print((_current + interval) / 1000, _lights, _textWorker);
            }
            _current += interval;
        }

    }
}
