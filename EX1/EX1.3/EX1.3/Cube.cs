using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1._3
{
    internal class Cube
    {// не враховано подібність алгоритму на дослідженні грані.
        int[,,] _cube;

        public Cords StartCords { get; set; } = new Cords();
        public Cords EndCord { get; private set; } = new Cords();
        

        public Cube(int size)
        {// Це тільки один із способів згенерувати куб.
            if(size <= 0)
            {
                throw new ArgumentOutOfRangeException("Size should be > 0 try again!");
            }
            _cube = new int[size, size, size];
            Random random = new Random();
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    for (int l = 0; l < size; l++)
                    {
                        _cube[i, j, l] = random.Next(0, 2);
                    }
                }
            }
        }

        public bool CheckForHole()
        {
            for(int i = 0; i < _cube.GetLength(0); i++)
            {
                for (int j = 0; j < _cube.GetLength(1); j++)
                {
                    for (int l = 0; l < _cube.GetLength(2); l++)
                    {
                        if (_cube[i, j, l] == 0)
                        {// Ви губите стартову точку
                            bool contains = false;
                            StartCords.X = i;
                            StartCords.Y = j;
                            StartCords.Z = l;

                            if (i == 0)
                            {
                                if (CheckForVertical(ref contains, i + 1, j, l))
                                {
                                    return true;
                                }
                            }
                            else if (l == 0)
                            {
                                if (CheckForLocalHorizontal(ref contains, i, j, l + 1))
                                {
                                    return true;
                                }
                            }
                            else if (j == 0)
                            {
                                if (CheckForLocalVertical(ref contains, i, j + 1, l))
                                {
                                    return true;
                                }
                            }
                            else if((j == 0 && l == 0) || (j == _cube.GetLength(1) - 1 && l == 0))
                            {
                                int jIncrement = j == 0 ? 1 : -1;
                                int jArg = jIncrement == -1 ? j - 1 : j + 1;
                                if (CheckForDiagonal(ref contains, i, jArg, l + 1, jIncrement))
                                {
                                    return true;
                                }
                            }
                            else
                            {
                                StartCords = new Cords();
                            }
                        }
                    }
                }
            }
            return false;
        }

        private bool CheckForDiagonal(ref bool contains, int i, int j, int l, int jIncrement)
        {
            if (_cube[i, j, l] == 0)
            {
                bool statement = jIncrement == -1 ? j == 0 : j == _cube.GetLength(1) - 1;
                if (statement)
                {
                    SetEndCoords(ref contains, i, j, l);
                    return contains;
                }
                if (jIncrement == -1)
                {
                    j -= 1;
                }
                else
                    j += 1;
                contains = CheckForDiagonal(ref contains, i, j, l + 1, jIncrement);
            }
            else
            {
                contains = false;
            }
            return contains;
        }

        private bool CheckForLocalVertical(ref bool contains, int i, int j, int l)
        {
            if (_cube[i, j, l] == 0)
            {
                if (j == _cube.GetLength(1) - 1)
                {
                    SetEndCoords(ref contains, i, j, l);
                    return contains;
                }
                contains = CheckForLocalVertical(ref contains, i, j + 1, l);
            }
            else
            {
                contains = false;
            }
            return contains;
        }

        private bool CheckForLocalHorizontal(ref bool contains, int i, int j, int l)
        {
            if (_cube[i, j, l] == 0)
            {
                if(l == _cube.GetLength(2) - 1)
                {
                    SetEndCoords(ref contains, i, j, l);
                    return contains;
                }
                contains = CheckForLocalHorizontal(ref contains, i, j, l + 1);
            }
            else
            {
                contains = false;
            }
            return contains;
        }

        private bool CheckForVertical(ref bool contains, int i, int j, int l)
        {
            if (_cube[i, j, l] == 0)
            {
                if (i == _cube.GetLength(0) - 1)
                {
                    SetEndCoords(ref contains, i, j, l);
                    return contains;
                }
                contains = CheckForVertical(ref contains, i + 1, j, l);
            }
            else
            {
                contains = false;
            }
            return contains;
        }

        private void SetEndCoords(ref bool contains, int i, int j, int l)
        {
            contains = true;
            EndCord.X = i;
            EndCord.Y = j;
            EndCord.Z = l;
        }
    }
}
