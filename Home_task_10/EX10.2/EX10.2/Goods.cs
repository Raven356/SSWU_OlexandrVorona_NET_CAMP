using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10._2
{
    internal abstract class Goods : IGoods
    {

        private decimal _weight;
        private decimal _size;
        private string _name;
        private decimal _price;
        protected Goods(string name, decimal size, decimal weight) 
        { 
            _name = name;
            _size = size;
            _weight = weight;
        }

        public decimal Weight { get => _weight; }
        public decimal Size { get => _size; }
        public string Name { get => _name; }
        public decimal Price { get => _price; set => _price = value; }

        public abstract void Accept(IVisitor visitor);
    }
}
