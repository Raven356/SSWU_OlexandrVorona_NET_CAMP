using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EX3._2
{
    internal class ConsoleWorker
    {
        public void Write(string text) { Console.WriteLine(text); }
        public string Read() { return Console.ReadLine(); }
    }
}
