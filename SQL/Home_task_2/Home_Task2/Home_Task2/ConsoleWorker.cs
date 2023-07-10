using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Task2
{
    internal class ConsoleWorker : IInterfaceWorker
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }

        public string Read() 
        { 
            return Console.ReadLine();
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
