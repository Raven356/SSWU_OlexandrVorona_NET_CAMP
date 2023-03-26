using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1._1
{
    internal class SnakeArray
    {
        private int m = 4;
        private int n = 3;
        public int[,] Arr { get; set; }
        public int M { get { return m; } set {
                if (value > 0)
                    m = value;
                else
                    throw new ArgumentException("Second argument was wrong try again!");
            } 
        }
        public int N { get {return n; } set {
                if (value > 0)
                    n = value;
                else throw new ArgumentException("First argument was wrong try again!");
            } 
        }

        public SnakeArray(int n = 3, int m = 4)
        {
            M = m;
            N = n;
        }

        public void FillArray()
        {
            Arr = new int[n, m];
            int maxCol = m - 1;
            int maxRow = n - 1;
            int minRow = 0;
            int minCol = 0;
            int start = 1;
            int condition = m * n;
            while(condition >= start)
            {
                
                for (int i = minRow; i <= maxRow; i++)
                {
                    Arr[i, minCol] = start++;
                    if (start > condition)
                        return;
                }
                minCol++;
                for(int j = minCol; j <= maxCol; j++)
                {
                    Arr[maxRow, j] = start++;
                    if (start > condition)
                        return;
                }
                maxRow--;
                for (int i = maxRow; i >= minRow; i--)
                {
                    Arr[i, maxCol] = start++;
                    if (start > condition)
                        return;
                }
                maxCol--;

                for(int j = maxCol; j >= minCol; j--)
                {
                    Arr[minRow, j] = start++;
                    if (start > condition)
                        return;
                }
                minRow++;
            }
        }

        //works for nxn
        public void FillReverseArray()
        {
            Arr = new int[n, m];
            int condition = n * m;
            int start = 1;
            int minRow = n % 2 == 0 ? n / 2 - 1 : n / 2;
            int minCol = m % 2 == 0 ? m / 2 - 1 : m / 2;
            int maxRow = minRow + 1;
            int maxCol = minCol + 1;

            int curRow = minRow;
            int curCol = minCol;
            while (start <= condition)
            {
                {
                    GoDown(ref curRow, ref curCol, ref minCol, ref start, ref maxRow);
                    if (start > condition)
                        return;

                    GoRight(ref curRow, ref curCol, ref minRow, ref start, ref maxCol);
                    if (start > condition)
                        return;

                    GoUpp(ref curRow, ref curCol, ref minRow, ref start, ref maxCol);
                    if (start > condition)
                        return;

                    GoLeft(ref curRow, ref curCol, ref minCol, ref start, ref maxRow);
                    if (start > condition)
                        return;
                }
            }
        }

        private void GoLeft(ref int curRow, ref int curCol, ref int minCol, ref int start, ref int maxRow)
        {
            for (int j = curCol; j >= minCol; j--)
            {

                Arr[curRow, j] = start++;
                if (start > m * n)
                    return;
            }
            if (maxRow < n - 1)
                maxRow++;
            curCol = minCol;
            curRow++;
        }
        private void GoUpp(ref int curRow, ref int curCol, ref int minRow, ref int start, ref int maxCol)
        {
            for (int i = curRow; i >= minRow; i--)
            {

                Arr[i, curCol] = start++;
                if (start > m * n)
                    return;

            }
            if (maxCol < m - 1)
                maxCol++;
            curRow = minRow;
            curCol--;
        }

        private void GoRight(ref int curRow, ref int curCol, ref int minRow, ref int start, ref int maxCol)
        {
            for (int j = curCol; j <= maxCol; j++)
            {

                Arr[curRow, j] = start++;
                if (start > m * n)
                    return;
            }
            curCol = maxCol;
            curRow--;
            if (minRow > 0)
                minRow--;
        }

        private void GoDown(ref int curRow, ref int curCol, ref int minCol, ref int start, ref int maxRow)
        {
            for (int i = curRow; i <= maxRow; i++)
            {

                Arr[i, curCol] = start++;
                if (start > m * n)
                    return;
            }
            curRow = maxRow;
            curCol++;
            if (minCol > 0)
                minCol--;
        }

        public void Print()
        {
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                for (int j = 0; j < Arr.GetLength(1); j++)
                {
                    Console.Write(Arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
