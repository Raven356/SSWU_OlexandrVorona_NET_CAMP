using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4._1
{
    internal class StatementFinder
    {

        private List<string> _endElements = new List<string>() {".", "?", "!" };

        public List<List<string>> FindStatements(List<string> text) {
            List<List<string>> result = new List<List<string>>();
            result.Add(new List<string>());
            for(int i = 0; i < text.Count; i++)
            {
                for(int j = 0; j < text[i].Length; j++)
                {
                    int ind = result.Count - 1;
                    if (!(text[i][j].Equals(' ') && result[ind].Count == 0))
                    {
                        result[ind].Add(text[i][j].ToString());
                    }
                    if (_endElements.Contains(text[i][j].ToString()))
                    {
                        if (!(result[ind].Contains("(") && result[ind].Contains(")"))
                            && !(result[ind].Contains("[") && result[ind].Contains("]"))
                            && !(result[ind].Contains("{") && result[ind].Contains("}")))
                        {
                            result[ind].Clear();
                        }
                        else
                        {
                            result.Add(new List<string>());
                        }

                    }
                }
                if (i == text.Count - 1 && result[result.Count - 1].Count == 0)
                {
                    result.RemoveAt(result.Count - 1);
                }
            }
            return result; 
        }

    }
}
