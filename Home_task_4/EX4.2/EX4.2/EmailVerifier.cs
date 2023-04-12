using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4._2
{
    internal class EmailVerifier
    {
        private List<string> _emails;
        private List<string> _lexems;
        private List<string> _restrictedSpecialSymbols;

        public EmailVerifier()
        {
            _emails = new List<string>();
            _lexems = new List<string>();
            _restrictedSpecialSymbols = new List<string> {",", "\"", "(", ")", ":", 
                ";", "\\", "[", "]", "<", ">", " ", "{", "}", "@", "..", "_" };
        }

        public List<string> FindEmailsAndLexems(List<string> text) {

            List<string> enteredText = text;

            foreach (var x in enteredText)
            {
                string withoutComments = DeleteComments(x);
                if (withoutComments.Contains("@"))
                {
                        var splited = withoutComments.Split("@");
                        string domainPart = splited[splited.Length-1];

                        StringBuilder localBuild = new StringBuilder();
                        for(int i = 0; i < splited.Length - 1; i++)
                        {
                            if(i !=  splited.Length - 2)
                                localBuild.Append(splited[i] + "@");
                            else
                                localBuild.Append(splited[i]);
                        }

                        string localPart = localBuild.ToString();

                    if (localPart.Length != 0)
                    {
                        if (domainPart.Length == 0 || localPart.Length > 64 || localPart.First().Equals('.') || localPart.Last().Equals('.')
                            || CheckForSpecialInDomain(domainPart) || CheckForSpecialInLocal(localPart, domainPart))
                        {
                            _lexems.Add(localPart + "@" + domainPart);
                        }
                        else
                            _emails.Add(withoutComments);
                    }
                }
            }
            if(_lexems.Count> 0)
                _lexems.Add("End of lexems\n");
            if (_emails.Count > 0)
                _emails.Add("End of emails\n");
            return new List<string>(_lexems.Concat(_emails));
        }

        private string DeleteComments(string text)
        {
            int startComment = 0;
            int endComment = 0;

            while((startComment = text.IndexOf("(")) != -1 && (endComment = text.IndexOf(")")) != -1)
            {
                text = text.Remove(startComment, endComment - startComment + 1);
            }

            return text;
        }

        private bool CheckForSpecialInLocal(string localPart, string domainPart)
        {
            if(localPart.Contains("/"))
                return true;
            string[] splited = localPart.Split("\"");
            int start = 0;
            if (splited[0].Length != 0 && splited.Length > 1)
                start = 1;
            

            for(int i = start; i < splited.Length; i += 2)
            {
                if (splited[i].Length == 0)
                {
                    return true;
                }
                for(int j = 0; j < _restrictedSpecialSymbols.Count - 1; j++)
                {
                    if (splited[i].Contains(_restrictedSpecialSymbols[j]))
                    {
                        return true;
                    }
                }
            }

            start = start == 0? 1 : 0;
            if (splited.Length > 1)
            {
                for (int i = start; i < splited.Length; i += 2)
                {
                    for (int j = 0; j < _restrictedSpecialSymbols.Count - 1; j++)
                    {
                        if (splited[i].Contains(_restrictedSpecialSymbols[j]))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            return false;
        }

        private bool CheckForSpecialInDomain(string domainPart)
        {
            foreach(var x in _restrictedSpecialSymbols)
            {
                if(domainPart.Contains(x))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
