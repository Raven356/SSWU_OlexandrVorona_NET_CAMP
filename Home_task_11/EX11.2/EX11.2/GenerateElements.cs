using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11._2
{
    internal class GenerateElements
    {
        public void Generate()
        {
            using StreamWriter streamWriter = new StreamWriter("startFile.txt");
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                streamWriter.WriteLine($"{random.Next(0, 101)}");
            }
        }
    }
}
