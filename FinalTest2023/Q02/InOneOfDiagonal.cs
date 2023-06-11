using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest2023.Q02
{
    public class InOneOfDiagonalClass
    {
        private static bool IsInDiagonal(int[,] arr, int value)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (arr[i,i] == value)
                    return true;
                if (arr[i, arr.GetLength(0) - i - 1] == value)
                    return true;
            }
            return false;

        }
        public static bool AllArrayInOneOfDiagonal(int[,] arr)
        {
            if (arr == null)
                return true;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (IsInDiagonal(arr, arr[i, j]) == false)
                    {
                        return false;
                    }
                }
                
            }

            return true;


        }

       
    }
}
