using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetNumbersWhenSumOfDigitsGreaterThanNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 15, 81, 3, 8, 111, 9, 10011};
            int num = 8;
            int[] result = GetNumbersWhenSumOfDigitsGreaterThanNum(num, arr);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadKey();
        }

        public static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        public static int[] GetNumbersWhenSumOfDigitsGreaterThanNum(int num, int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (SumOfDigits(arr[i]) > num)
                {
                    counter++;
                }
            }
            int[] result = new int[counter];
            int j = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (SumOfDigits(arr[i]) > num)
                {
                    result[j] = i;
                    j++;
                }
            }

            return result;
        }
    }
}
