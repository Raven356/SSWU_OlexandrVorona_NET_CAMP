﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EX3._2
{
    internal class StringWorker
    {
        public int? FindSecondSubString(string phrase, string subString)
        {
            int index = phrase.IndexOf(subString, phrase.IndexOf(subString) + 1);
            return index == -1 ? null : index;
        }

        public int CountUpperStartWords(string phrase)
        {// слід використати 2 параметр в Split. Інакше при кількох пропусках між словами будуть сюрпризи
            string[] splitPhrase = phrase.Split(" ");
            int count = splitPhrase.Count(x => Char.IsUpper(x, 0));
            return count;
        }

        public string ChangeWordWithDoublingOnPhrase(string phrase, string changePhrase)
        {
            string[] splitPhrase = phrase.Split(" ");
            for (int i = 0; i < splitPhrase.Length; i++)
            {
                for(int j = 0; j < splitPhrase[i].Length - 1; j++)
                {
                    if (splitPhrase[i].ToLower()[j] == splitPhrase[i].ToLower()[j + 1])
                    {
                        phrase = phrase.Replace(splitPhrase[i], changePhrase);
                        break;
                    }
                }
            }
            return phrase;
        }
    }
}
