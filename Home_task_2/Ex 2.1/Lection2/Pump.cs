﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2
{
    internal abstract class Pump
    {
        private readonly double _power;
        private bool _isOn = false;

        public bool IsOn { get {return _isOn; } set { _isOn = value; } }

        public Pump(double power)
        {
            if (_power < 0)
                throw new ArgumentOutOfRangeException("Power should be posive");
            _power = power;
        }
//задумайтесь, коли спрацьовуватиме цей метод.
        public abstract void ChangeState();

        public override string? ToString()
        {
            return $"Power of pump {_power}, state: {_isOn}";
        }
    }
}
