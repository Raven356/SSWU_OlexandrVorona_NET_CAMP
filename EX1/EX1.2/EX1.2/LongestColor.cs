using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1._2
{
    internal class LongestColor
    {
        int[,] _arr;
        //лишнє поле. Це просто результат одного з методів.
        public Cord Cords { get; set; }

        public LongestColor(int i, int j)
        {
            _arr = new int[i, j];
            Cords = new Cord();
        }

        public void GenerateArray()
        {
            Random random = new Random();
            for(int i = 0; i < _arr.GetLength(0); i++)
            {
                for(int j = 0;  j < _arr.GetLength(1); j++)
                {
                    _arr[i, j] = random.Next(0, 16);
                    // Роздруки тут лишні
                    Console.Write(_arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public Cord FindLongest()
        {
            int currentColor = -1;
            
            Cord current = new Cord();
            for(int i = 0; i < _arr.GetLength(0); i++)
            {
                for(int j = 0; j < _arr.GetLength(1); j++)
                {
                    if(currentColor == -1)
                    {
                        currentColor = _arr[i, j];
                        SetCurrent(current, i, j, 1);
                        // уникайте такі конструкції
                        continue;
                    }
                    if(currentColor != _arr[i, j])
                    {
                        currentColor = _arr[i, j];
                        if(Cords.LongestSize < current.LongestSize)
                        {

                            if(j != 0)
                                SetCords(current.XStart, current.YStart, i, j - 1, current.LongestSize);
                            else
                                SetCords(current.XStart, current.YStart, i, 0, current.LongestSize);
                        }
                        SetCurrent(current, i, j, 1);
                    }
                    else if(currentColor == _arr[i, j])
                    {
                        current.LongestSize++;
                        if(j == _arr.GetLength(1) - 1 && Cords.LongestSize < current.LongestSize)
                        {
                            SetCords(current.XStart, current.YStart, i, j, current.LongestSize);
                        }
                    }
                }
                currentColor = -1;
            }
            return Cords;
        }
        private void SetCurrent(Cord current, int xStart, int yStart, int size)
        {
            current.XStart = xStart;
            current.YStart = yStart;
            current.LongestSize = size;
        }

        private void SetCords(int xStart, int yStart, int xEnd, int yEnd, int size)
        {
            Cords.XStart = xStart;
            Cords.YStart = yStart;
            Cords.LongestSize = size;
            Cords.XEnd = xEnd;
            Cords.YEnd = yEnd;
        }
    }
}
