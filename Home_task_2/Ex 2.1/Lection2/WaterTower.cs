using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2
{
    internal abstract class WaterTower
    {
        private readonly int _maxLevel;
        private double _currentLevel;

        private Pump _pump;

        public WaterTower(int maxLevelWater, Pump pump)
        {
            if(maxLevelWater < 0) {
                throw new ArgumentOutOfRangeException("Max level should be positive");
            }
            _maxLevel = maxLevelWater;
            _pump = pump;
        }

        public abstract void GiveWater(int consumption);

        public override string? ToString()
        {
            return $"Current level of water - {_currentLevel}, pump assigned to tower: {_pump}";
        }
    }
}
