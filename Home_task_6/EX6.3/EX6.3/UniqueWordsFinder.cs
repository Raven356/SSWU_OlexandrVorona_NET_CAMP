using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6._3
{
    internal class UniqueWordsFinder
    {
        //return words that doesn't have duplicates
        public IEnumerable<string> FindWithoutDuplicates(string text)
        {// Краще Split використати з 2 параметрами.
            string[] words = text.ToLower().Split(' ', ',', '.', '!', '?', ';', ':');
            foreach (string word in words)
            {
                if (words.Count(x => x.Equals(word)) == 1 && !word.Equals(""))
                {
                    yield return word;
                }
            }
        }

        //return only unique words
        public IEnumerable<string> FindUnique(string text)
        {
            string[] words = text.ToLower().Split(' ', ',', '.', '!', '?', ';', ':');
            for(int i = 0; i < words.Length; i++)
            {
                bool returned = false;
                if (!words[i].Equals(""))
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (words[i].Equals(words[j]))
                        {
                            returned = true;
                            break;
                        }
                    }
                    if (!returned)
                    {
                        yield return words[i];
                    }
                }
            }
        }
    }
}
