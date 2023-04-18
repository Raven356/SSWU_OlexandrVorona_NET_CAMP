using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection2
{
    internal abstract class Simulator
    {

        private WaterTower _waterTower;
        private Pump _pump;
        // якщо вже працюємо зі списком, то варто надати можливість додавати і вилучати користувачів.
        private List<User> _users;
// А хто має створювати ці екземпляри, який клас?
        public Simulator(WaterTower waterTower, Pump pump, List<User> users)
        {
            _waterTower = waterTower;
            _pump = pump;
            //тут треба глибоку копію
            _users = users;
        }

        //method which is responsible for checking state of water tower
        public abstract void CheckState();

        public override string? ToString()
        {
            return $"Working with users: {_users}, water tower: {_waterTower}, pump: {_pump}";
        }
    }
}
