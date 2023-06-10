using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX11._1
{
    internal class QuickSort<T> where T : IComparable<T>
    {
        public void Sort(T[] arr, int first, int last, int choice)
        {
            int i;
            if (first >= last)
            {
                return;
            }
            switch (choice)
            {
                case 1:
                    
                    i = FirstElementPartition(arr, first, last);

                    break;
                case 2:
                    i = RandomizedPartition(arr, first, last);
                    break;
                case 3:
                    i = MedianaPartition(arr, first, last);
                    break;
                default:
                    return;
            }
            Sort(arr, first, i - 1, choice);
            Sort(arr, i + 1, last, choice);
        }

        private int RandomizedPartition(T[] arr, int first, int last)
        {
            Random random = new Random();
            int i = random.Next(first, last + 1);
            (arr[i], arr[last]) = (arr[last], arr[i]);
            return LastElementPartition(arr, first, last);
        }

        private int MedianaPartition(T[] arr, int first, int last)
        {
            int pivotIndex = (first + last) / 2;
            T coreElement = arr[pivotIndex];
            int i = first;
            int j = last;
            while (i <= j)
            {
                if (arr[i].CompareTo(coreElement) <= 0)
                {
                    i++;
                }
                else if (arr[j].CompareTo(coreElement) >= 0)
                {
                    j--;
                }
                else
                {
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                    i++;
                    j--;
                }
            }
            if(pivotIndex < j)
            {
                (arr[j], arr[pivotIndex]) = (arr[pivotIndex], arr[j]);
                pivotIndex = j;
            }
            else if(pivotIndex > i)
            {
                (arr[i], arr[pivotIndex]) = (arr[pivotIndex], arr[i]);
                pivotIndex = i;
            }
            return pivotIndex;
        }

        private int LastElementPartition(T[] arr, int first, int last)
        {
            T coreElement = arr[last];
            int i = first - 1;
            for(int j = first; j <= last - 1; j++)
            {
                if (arr[j].CompareTo(coreElement) < 0)
                {
                    i += 1;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            (arr[i + 1], arr[last]) = (arr[last], arr[i + 1]);
            return i + 1;
        }

        private int FirstElementPartition(T[] arr, int first, int last)
        {
            T coreElement = arr[first];
            int j = last;
            for(int i = last; i > first; i--)
            {
                if (arr[i].CompareTo(coreElement) > 0)
                {
                    j--;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                    
                }
            }
            (arr[j], arr[first]) = (arr[first], arr[j]);
            return j - 1;
        }
    }
}
