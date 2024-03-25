using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagrut2023Q02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 9 };

            Console.WriteLine(MinningNum(arr));
        }

        public static int MinningNum(int[] arr)
        {
            if (arr.Length < 4)
                return -1;
            int diff1 = arr[1] - arr[0];
            int diff2 = arr[2] - arr[1];
            int diff3 = arr[3] - arr[2];

            int diff;
            if (diff1 == diff2)
                diff = diff1;
            else if (diff2 == diff3)
                diff = diff2;
            else
                diff = diff3;


            for (int i = 0; i < arr.Length - 1; i++)
            {
                int delta = arr[i + 1] - arr[i];
                if (delta != diff)
                    return arr[i] + diff;
            }
            return -1;
        }
    }
}
