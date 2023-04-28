using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection8
{
    internal class TestComparer : IComparer<Test>
    {
        public int Compare(Test? x, Test? y)
        {
            return (x is null || y is null) ? -1 : x.Age.CompareTo(y.Age);
        }
    }
}
