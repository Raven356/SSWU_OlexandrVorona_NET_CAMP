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

        public double DebtOfWater { get { return _consumption - _used; }}

        public User(double consumption) {
            if (consumption < 0)
                throw new ArgumentOutOfRangeException("Consumption should be positive");
            _consumption = consumption;
        }

        public abstract void TakeWater() ;

        public override string? ToString()
        {
            return $"User consumption: {_consumption}, used water: {_used}";
        }
    }
}
