using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4._2
{
    internal class TextSpliter
    {
        public List<string> SplitText(string text)
        {
            List<string> split = new List<string>();
            string[] splits = text.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in splits)
            {
                split.Add(s);
            }
            return split;
        }
    }
}
