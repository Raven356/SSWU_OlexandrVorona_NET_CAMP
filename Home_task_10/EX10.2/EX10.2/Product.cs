using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10._2
{
    internal class Product : Goods
    {
        private DateTime _dateOfExpire;

        public Product(string name, decimal size, decimal weight, DateTime dateOfExpire):base(name, size, weight)
        { 
            _dateOfExpire = dateOfExpire;
        }

        public DateTime DateOfExpire { get => new DateTime(_dateOfExpire.Year, _dateOfExpire.Month, _dateOfExpire.Day); }

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitProduct(this);
        }

        public override string? ToString()
        {
            return $"Product's {Name} price is {Price}";
        }
    }
}
