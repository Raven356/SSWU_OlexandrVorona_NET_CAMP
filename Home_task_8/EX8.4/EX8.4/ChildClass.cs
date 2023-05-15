using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8._4
{
    internal class ChildClass : ParentClass
    {
        public ChildClass() {
            DoSomething();
        }

        protected override void DoSomething()
        {
            base.DoSomething();
        }

        protected override void About()
        {
            Console.WriteLine("I am child class");
        }
    }
}
