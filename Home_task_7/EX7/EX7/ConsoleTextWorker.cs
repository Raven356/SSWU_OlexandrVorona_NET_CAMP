using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX7
{
    internal class ConsoleTextWorker : ITextWorker
    {
        public void Print(string text)
        {
            Console.Write(text);
        }

        public void PrintLine(string text)
        {
            Console.WriteLine(text);
        }

        public object Read()
        {
            return Console.ReadLine();
        }
    }
}
