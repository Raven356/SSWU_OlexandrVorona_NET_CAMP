using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2
{
    internal abstract class Simulator
    {
        //user

        private WaterTower _waterTower;
        private Pump _pump;
        private User _user;

        public Simulator(WaterTower waterTower, Pump pump, User user)
        {
            _waterTower = waterTower;
            _pump = pump;
            _user = user;
        }

        //method which is responsible for checking state of water tower
        public abstract void CheckState();

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
