using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2021BQ03
{
    internal class Program
    {
        public static bool IsCorner(int[,] array)
        {
            if (array.GetLength(0) == array.GetLength(1) &&
                array.GetLength(0) > 0)
            {
                int n = array.GetLength(0);
                ;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        int low = Math.Min(i, j);
                        if (array[i, j] != low + 1)
                            return false;
                    }

                   
                }
                return true;
            }
            else
            {
                return false;
            }

            return false;


        }
        static void Main(string[] args)
        {
            int[,] array1 =
           { {1, 1, 1},
             { 1, 2, 2},
             { 1, 2, 3}
            };

           // Console.WriteLine(IsCorner(array1));

            int[,] array2 =
            {   {1, 1, 1, 1, 1},
                {1, 2, 2, 2, 2},
                {1, 2, 3, 3, 3},
                {1, 2, 3, 4, 4},
                {1, 2, 3, 4, 5}
            };

            Console.WriteLine(IsCorner(array2));


        }
    }
}
