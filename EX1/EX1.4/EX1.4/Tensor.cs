using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1._4
{
    internal class Tensor
    {
        public int[]? TensArr { get; private set; }
        public List<int> Res { get; } = new List<int>();
        private List<int> _cords = new List<int>();
        int _dimension;


        public void InitTensor(int dimension, params int[] dimensions)
        {
            if (dimensions.Length != dimension - 1 && dimension != 1)
                throw new ArgumentException("Entered data was wrong! Try again!");
            int size = 1;
            _dimension = dimension - 1;

            foreach (var x in dimensions)
            {
                size *= x;
                Res.Add(x);
            }

            TensArr = dimension == 1 ? new int[] { dimensions[0] } : new int[size];

            foreach (var x in Res)
            {
                size /= x;
                _cords.Add(size);
            }
        }

        //fill by recursion(fill like array, considering positions)
        public void FillTensor(int start, IEnumerable<int> param)
        {
            for(int i = 0; i < Res[start]; i++)
            {
                if(start < _dimension - 1)
                {
                    List<int> tmp = param.ToList();
                    tmp.Add(i);
                    FillTensor(start + 1, tmp);
                }
                else if(start == _dimension - 1)
                {
                    int val = 0;
                    List<int> parList = param.ToList();
                    parList.Add(i);
                    Random random = new Random();
                    for(int j = 0; j < _cords.Count; j++)
                    {
                        val += _cords[j] * parList[j];
                    }
                    TensArr[val] = random.Next(1, 10);
                }
            }
        }

        public void PrintTensor(int start, IEnumerable<int> param)
        {
            if(_dimension == 0)
            {
                Console.WriteLine(TensArr[0]);
                return;
            }

            for (int i = 0; i < Res[start]; i++)
            {
                if (start < _dimension - 1)
                {
                    List<int> tmp = param.ToList();
                    tmp.Add(i);
                    PrintTensor(start + 1, tmp);
                }
                else if (start == _dimension - 1)
                {
                    int val = 0;
                    List<int> parList = param.ToList();
                    parList.Add(i);
                    Random random = new Random();
                    for (int j = 0; j < _cords.Count; j++)
                    {
                        val += _cords[j] * parList[j];
                    }
                    Console.Write(TensArr[val] + " ");
                }
            }
            Console.WriteLine();
        }

        //random order fill
        public void FillRandomValuesTensor()
        {
            Random random = new Random();
            for(int i = 0; i < TensArr.Length; i++)
            {
                TensArr[i] = random.Next(1, 10);
            }
            Console.WriteLine();
        }

        
    }
}
