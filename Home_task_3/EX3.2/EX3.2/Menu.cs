using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3._2
{
    internal class Menu
    {
        private string _answer;
        public string Answer { get { return _answer; } }
        public void StartMenu()
        {
            ConsoleWorker consoleWorker = new ConsoleWorker(); 
            consoleWorker.Write("Enter your message:");
            string answer = consoleWorker.Read();
            StringWorker stringWorker = new StringWorker();
            while (true)
            {
                try
                {
                    consoleWorker.Write("Enter task:\n" +
                        "1)Find the index of the second occurrence of the given substring in the text\n" +
                        "2)Return the number of words starting with an uppercase letter\n" +
                        "3)Replace all words containing doubling of letters with the given text");
                    int choice = int.Parse(consoleWorker.Read());
                    switch (choice)
                    {
                        case 1:
                            consoleWorker.Write("Enter searched substring:");
                            string substring = consoleWorker.Read();
                            answer = stringWorker.FindSecondSubString(answer, substring).ToString();
                            _answer = answer == "" ? "null" : answer;
                            return;
                        case 2:
                            _answer = stringWorker.CountUpperStartWords(answer).ToString();
                            return;
                        case 3:
                            consoleWorker.Write("Enter phrase on which you want to change words with doubling:");
                            string changePhrase = consoleWorker.Read();
                            _answer = stringWorker.ChangeWordWithDoublingOnPhrase(answer, changePhrase);
                            return;
                        default:
                            consoleWorker.Write("Please enter from 1 to 3");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    consoleWorker.Write(ex.Message);
                }

            }
        }
    }
}
