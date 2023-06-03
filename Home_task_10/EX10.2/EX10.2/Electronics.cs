using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10._2
{
    internal class Electronics : Goods
    {
        private static decimal _maxGabarites = 144;
        public Electronics(string name, decimal size, decimal weight) : base(name, size, weight)
        {
            
        }

        public decimal MaxGabarites { get => _maxGabarites; }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitElectronics(this);
        }

        public override string? ToString()
        {
            return $"Electronic's {Name} price is {Price}";
        }
    }
}
