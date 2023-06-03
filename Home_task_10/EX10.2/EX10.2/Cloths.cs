using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10._2
{
    internal class Cloths : Goods
    {
        public Cloths(string name, decimal size, decimal weight) : base(name, size, weight)
        {
            
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitCloths(this);
        }

        public override string? ToString()
        {
            return $"Cloth's {this.Name} price is {this.Price}";
        }
    }
}
