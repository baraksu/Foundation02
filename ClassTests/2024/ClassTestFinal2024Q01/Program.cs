using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestFinal2024Q01
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] Fill(int[] arr, int num)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0 || i % 5 == 0)
                {
                    result[i] = num;
                }
                else
                {
                    result[i] = arr[i];
                }
            }
            return result;
        }
    }
}
