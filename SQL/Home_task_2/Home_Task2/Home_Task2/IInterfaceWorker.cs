using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task2
{
    internal interface IInterfaceWorker
    {
        void Write(string text);
        string Read();

        void Clear();
    }
}
