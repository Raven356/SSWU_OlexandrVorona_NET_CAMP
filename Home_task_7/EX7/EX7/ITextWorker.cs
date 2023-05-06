using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7
{
    internal interface ITextWorker
    {
        void PrintLine(string text);

        void Print(string text);

        object Read();
    }
}
