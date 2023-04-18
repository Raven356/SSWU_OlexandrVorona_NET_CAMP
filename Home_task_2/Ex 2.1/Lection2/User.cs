using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2
{
    internal abstract class User
    {
        private double _consumption;

        private double _used;

// у Вас користувач не може мати багато бажань. тільки 1 раз при створенні)
        public double DebtOfWater { get { return _consumption - _used; }}

        public User(double consumption) {
            if (consumption < 0)
                throw new ArgumentOutOfRangeException("Consumption should be positive");
            _consumption = consumption;
        }

        public abstract void TakeWater(WaterTower waterTower) ;

        public override string? ToString()
        {
            return $"User consumption: {_consumption}, used water: {_used}";
        }
    }
}
