using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10._2
{
    internal interface IGoods
    {
        void Accept(IVisitor visitor);
    }
}
