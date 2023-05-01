using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap4Example04SameDiagonal
{
    internal class Program
    {
        const int N = 5;
        static void Main(string[] args)
        {
        }

        static bool EqualCross1(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                if (m[i, i] != m[i, m.GetLength(0) - i - 1])
                    return false;
            }
            return true;
        }
        static bool EqualCross2(int [,] m)
        {
            int temp1 = 0, temp2 = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (i == j)
                        temp1 = m[i, j];
                    if (i + j == N - 1)
                        temp2 = m[i, j];
                }
                if (temp1!= temp2)
                    return false;
            }
            return true;
        }

    }
}
