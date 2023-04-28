using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lection8
{
    internal class Test
    {
        private string _name;
        private int _age;

        public Test(int age, string name) { 
            Age = age;
            Name = name;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }

        static public bool operator > (Test a, Test b)
        {
            return a.Age > b.Age;
        }

        static public bool operator <(Test a, Test b)
        {
            return a.Age < b.Age;
        }

        static public bool operator ==(Test a, Test b)
        {
            return a.Age == b.Age;
        }

        static public bool operator !=(Test a, Test b)
        {
            return a.Age != b.Age;
        }

        public override string? ToString()
        {
            return $"{Name} {Age}";
        }
    }
}
