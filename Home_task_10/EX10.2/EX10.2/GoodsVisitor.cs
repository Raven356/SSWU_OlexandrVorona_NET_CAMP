using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX10._2
{
    internal class GoodsVisitor : IVisitor
    {
        public void VisitCloths(Cloths cloths)
        {
            decimal sum = cloths.Weight * 12 + cloths.Size * 6;
            cloths.Price = sum;
        }

        public void VisitElectronics(Electronics electronics)
        {
            decimal sum = electronics.Weight * 12 + electronics.Size * 6;
            sum += electronics.Weight * electronics.Size > electronics.MaxGabarites ? (sum * 0.3m) : 0;
            electronics.Price = sum;
        }

        public void VisitProduct(Product product)
        {
            TimeSpan time = product.DateOfExpire - DateTime.Now;
            decimal sum = product.Weight * 12 + product.Size * 6 + (time.Days > 10 ? 0 : time.Days * 12);
            product.Price = sum;
        }
    }
}
