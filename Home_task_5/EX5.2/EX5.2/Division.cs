using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5._2
{
    internal class Division
    {
        private List<Division> _subDivisions;
        private List<Goods> _goods;
        private string _name;

        public List<Goods> Goods { get { return _goods; } }
        public List<Division> Subdivisions { get { return _subDivisions; } }

        public string Name { get { return _name; } }

        public Division()
        {

        }
        
        public Division(List<Division> subDivions, string name)
        {
            _subDivisions = subDivions;
            _name = name;
        }

        public Division(List<Goods> goods, string name) {
            _goods = goods;
            _name = name;
        }
    }
}
