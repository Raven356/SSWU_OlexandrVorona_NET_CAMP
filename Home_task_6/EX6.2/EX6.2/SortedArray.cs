using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6._2
{// Яка ефективність yield?
    internal class SortedArray
    {
        //sort by adding arraus into one
        public IEnumerable<int> SortArrays(params int[][] arrays)
        {
            int[] array = new int[arrays.Sum(x => x.Length)];
            for (int i = 0; i < arrays.Length; i++)
            {
                for(int j = 0; j < arrays[i].Length; j++)
                {
                    array[j + i * arrays[i].Length] += arrays[i][j];
                }

            }
            Array.Sort(array);
             foreach(int element  in array)
                yield return element;
        }

        //sort by going through all arrays
        public IEnumerable<int> SortArrays2 (params int[][] arrays)
        {
            int min = int.MaxValue;
            int amount = 0;
            List<int> prevMin = new List<int>();
            for (int x = 0; x < arrays.Sum(x => x.Length); x++)
            {
                for (int i = 0; i < arrays.Length; i++)
                {
                    int localMin = arrays[i].Where(x => !prevMin.Contains(x)).DefaultIfEmpty(int.MaxValue).Min();
                    if (min > localMin)
                    {
                        min = localMin;
                        amount = arrays[i].Count(x => x == min);
                    }
                    else if (min == localMin)
                    {
                        amount += arrays[i].Count(x => x == min);
                    }
                }
                for(int k = 0; k < amount; k++)
                {
                    if(k > 0)
                        ++x;
                    yield return min;
                }
                prevMin.Add(min);
                min = int.MaxValue;
            }
        }
    }
}
