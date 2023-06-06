using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap4Example06_DifferentDimension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];

            arr[0] = new int[2];
            arr[1] = new int[3];
            arr[2] = new int[4];

            Console.WriteLine("Enter Number to multi dimension array");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("arr values:");
            foreach (var array in arr)
            {
                foreach (var i in array)
                {
                    Console.Write(i + "\t");
                    
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
