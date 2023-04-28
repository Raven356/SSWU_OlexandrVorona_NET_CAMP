using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6._3
{
    internal class UniqueWordsFinder
    {
        public IEnumerable<string> FindUnique(string text)
        {
            string[] words = text.Split(' ', ',', '.', '!', '?', ';', ':');
            foreach (string word in words)
            {
                if (words.Count(x => x.Equals(word)) == 1 && !word.Equals(""))
                {
                    yield return word;
                }
            }
        }
    }
}
