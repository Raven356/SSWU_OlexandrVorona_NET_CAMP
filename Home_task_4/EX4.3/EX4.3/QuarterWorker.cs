﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX4._3
{
    internal class QuarterWorker
    {
        List<List<string>> _quartersInfo = new List<List<string>>();

        public QuarterWorker(List<List<string>> quartersInfo)
        {
            _quartersInfo = quartersInfo;
        }

        public string FindFlat(int quarterNumber, int flatNumber)
        {
            for (int i = 0; i< _quartersInfo.Count; i++)
            {
                string[] splited = _quartersInfo[i][0].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (int.Parse(splited[splited.Length - 1]) == quarterNumber){
                    for(int j = 1; j < _quartersInfo[i].Count; j++)
                    {
                        splited = RemoveEmptyOnStart(_quartersInfo[i][j].Split("; ", StringSplitOptions.RemoveEmptyEntries));

                        foreach (var x in splited)
                        {
                            if(x.Contains("Flat number:") || x.Contains("Номер квартири:"))
                            {
                                if(int.Parse(x.Split(": ", StringSplitOptions.RemoveEmptyEntries)[1]) == flatNumber)
                                {
                                    return _quartersInfo[i][j].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList().Aggregate((x, y) => x + " " + y);
                                }
                            }
                        }
                    }
                }
            }
            return "Flat wasn't found!";
        }

        public List<string> GetReport(int quarterNumber)
        {
            List<string> report = new List<string>();
            for(int i = 0; i < _quartersInfo.Count; i++) {
                string[] splited = _quartersInfo[i][0].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (int.Parse(splited[splited.Length - 1]) == quarterNumber)
                {
                    for(int j = 1; j < _quartersInfo[i].Count; j++)
                    {
                        splited = RemoveEmptyOnStart(_quartersInfo[i][j].Split("; ", StringSplitOptions.RemoveEmptyEntries));
                        StringBuilder stringBuilder = new StringBuilder();
                        foreach(var x in splited)
                        {
                            DateTime dateTime;

                            if(x == splited[splited.Length - 1])
                            {
                                string[] dateSplit = RemoveEmptyOnStart(x.Split(", ", StringSplitOptions.RemoveEmptyEntries));
                                foreach(var y in dateSplit)
                                {
                                    dateTime = DateTime.Parse(y);
                                    stringBuilder.Append(dateTime.ToString("MMMM") + ": " + dateTime.ToString("dd/MM/yy") + ", ");
                                }
                                stringBuilder.Remove(stringBuilder.Length - 2, 2);
                                stringBuilder.Append(";\t");
                            }
                            else if (!x.Contains("Address"))
                            {
                                string control = (x.Split(" ", StringSplitOptions.RemoveEmptyEntries)).ToList().Aggregate((x, y) => x + " " + y);
                                stringBuilder.Append(String.Format("{0,14};\t", control));
                            }
                        }
                        report.Add(stringBuilder.ToString());
                    }
                }
            }
            return report.Count == 0 ? new List<string> { "Quarter not found" } : report;
        }

        public string GetSurnameWithMaxDept(int quarterNumber, int price)
        {
            string answer = "";
            int max = 0;
            for(int i = 0; i < _quartersInfo.Count; i++)
            {
                string[] splited = _quartersInfo[i][0].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (int.Parse(splited[splited.Length - 1]) == quarterNumber)
                {
                    for (int j = 1; j < _quartersInfo[i].Count; j++)
                    {
                        splited = RemoveEmptyOnStart(_quartersInfo[i][j].Split("; ", StringSplitOptions.RemoveEmptyEntries));
                        int last = int.Parse(splited[3].Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
                        int now = int.Parse(splited[4].Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
                        if (max < (now - last) * price)
                        {
                            max = (now - last) * price;
                            answer = splited[2];
                        }
                    }
                }
            }
            return answer.Length == 0 ? "Quater wasn't found!" : answer;
        }

        public int GetFlatNumberWithZero(int quarterNumber)
        {
            int number = -1;
            for(int i = 0; i < _quartersInfo.Count;i++)
            {
                string[] splited = _quartersInfo[i][0].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (int.Parse(splited[splited.Length - 1]) == quarterNumber)
                {
                    for (int j = 1; j < _quartersInfo[i].Count; j++)
                    {
                        splited = RemoveEmptyOnStart(_quartersInfo[i][j].Split("; ", StringSplitOptions.RemoveEmptyEntries));
                        int last = int.Parse(splited[3].Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
                        int now = int.Parse(splited[4].Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
                        if (last == now)
                        {
                            number = int.Parse(RemoveEmptyOnStart(splited[0].Split(": ", StringSplitOptions.RemoveEmptyEntries))[1]);
                        }
                    }
                }
            }
            return number;
        }

        public List<string> GetPaymentSumForFlats(int price)
        {
            List<string> answer = new List<string>();
            for (int j = 1; j < _quartersInfo[0].Count; j++)
            {
                string[] splited = new string[0];
                int sum = 0;
                for (int i = 0; i < _quartersInfo.Count; i++)
                {
                    splited = _quartersInfo[i][j].Split("; ", StringSplitOptions.RemoveEmptyEntries);
                    int last = int.Parse(splited[3].Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
                    int now = int.Parse(splited[4].Split(" ", StringSplitOptions.RemoveEmptyEntries)[1]);
                    sum += now - last;
                }
                if(splited.Length != 0)
                    answer.Add(splited[0] + ", should pay: " + sum * price);
            }
            return answer;
        }

        public List<string> GetAmountOfDaysToNow()
        {
            List<string> answer = new List<string>();
            for(int i = 1; i < _quartersInfo[_quartersInfo.Count - 1].Count; i++)
            {
                DateTime now = DateTime.Now;
                string[] splited = RemoveEmptyOnStart(_quartersInfo[_quartersInfo.Count - 1][i].Split("; ", StringSplitOptions.RemoveEmptyEntries));
                string[] dateSplit = RemoveEmptyOnStart(splited[splited.Length - 1].Split(", ", StringSplitOptions.RemoveEmptyEntries));
                DateTime last = DateTime.Parse(dateSplit[dateSplit.Length - 1]);
                TimeSpan time = now - last;
                answer.Add(splited[0] + ", Time spent - " + (int)time.TotalDays);
            }
            return answer;
        }

        private string[] RemoveEmptyOnStart(string[] splited)
        {
            for(int i = 0; i < splited.Length; i++)
            {
                while (splited[i].IndexOf(' ') == 0)
                    splited[i] = splited[i].Remove(0, 1);
            }
            return splited;
        }
    }
}
