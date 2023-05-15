using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8._4
{
    internal class ParentClass
    {
        public ParentClass() {
            _myEvent += About;
            DoSomething();
        }
        protected event Action _myEvent;

        

        protected virtual void DoSomething()
        {
            _myEvent?.Invoke();
        }

        protected virtual void About()
        {
            Console.WriteLine("I am parent class");
        }
    }
}
