using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4._1
{
    internal class TextSpliter
    {
        public List<string> SplitText(string text) { 
            List<string> split = new List<string>();
            string[] splits = text.Split("\n", StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in splits) { 
                split.Add(line);
            }
            return split;
        }
    }
}
