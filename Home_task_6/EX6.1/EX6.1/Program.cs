﻿namespace EX6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiagonalMatrix diagonalMatrix = new DiagonalMatrix(5);
            foreach (int i in diagonalMatrix)
            {
                Console.WriteLine(i);
            }
        }
    }
}