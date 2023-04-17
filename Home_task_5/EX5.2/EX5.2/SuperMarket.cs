using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX5._2
{
    internal class SuperMarket
    {
        private List<Division> _divisions;
        private string _name;


        public string Name { get { return _name; } }

        public List<Division> Divisions { get {  return _divisions; } }

        public SuperMarket(List<Division> divisions, string name)
        {
            _divisions = divisions;
            _name = name;
        }
    }
}
