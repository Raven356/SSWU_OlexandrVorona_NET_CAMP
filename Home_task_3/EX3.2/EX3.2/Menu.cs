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
            Console.WriteLine("Enter your message:");
            string answer = Console.ReadLine();
            StringWorker stringWorker = new StringWorker();
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter task:\n" +
                        "1)Find the index of the second occurrence of the given substring in the text\n" +
                        "2)Return the number of words starting with an uppercase letter\n" +
                        "3)Replace all words containing doubling of letters with the given text");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter searched substring:");
                            string substring = Console.ReadLine();
                            _answer = stringWorker.FindSecondSubString(answer, substring).ToString();
                            return;
                        case 2:
                            _answer = stringWorker.CountUpperStartWords(answer).ToString();
                            return;
                        case 3:
                            Console.WriteLine("Enter phrase on which you want to change words with doubling:");
                            string changePhrase = Console.ReadLine();
                            _answer = stringWorker.ChangeWordWithDoublingOnPhrase(answer, changePhrase);
                            return;
                        default:
                            Console.WriteLine("Please enter from 1 to 3");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
