using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11._1
{
    internal class TestType : IComparable<TestType>
    {
        private int _element;

        public TestType(int element)
        {
            _element = element;
        }

        public int Element { get => _element; }

        public int CompareTo(TestType? other)
        {
            if(other._element > _element) return -1;
            if(other._element < _element) return 1;
            return 0;
        }
    }
}
