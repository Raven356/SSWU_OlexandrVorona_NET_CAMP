using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4._3
{
    internal class FileWorker
    {
        FileStream _stream;

        public List<List<string>> readFromFile(string fileName)
        {
            List<List<string>> answer = new List<List<string>>();
            try
            {
                _stream = File.OpenRead(fileName);
                StreamReader streamReader = new StreamReader(_stream);
                string text = "";
                int count = -1;
                while ((text = streamReader.ReadLine()) != null)
                {
                    if (text.Contains("Amount of flats"))
                    {
                        answer.Add(new List<string> { });
                        count++;
                    }
                    answer[count].Add(text);
                }
                return answer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<List<string>>();
            }
        }
    }
}
