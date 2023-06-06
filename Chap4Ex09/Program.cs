using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chap4Ex09
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            int[,] m = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 },  { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

            Print(m);
           // if (!Checking(m))
                Changing(m);
                Print(m);
        }

        static void Changing(int[,] m)
        {
            int temp;
            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = row; col < m.GetLength(1); col++)
                {
                    temp = m[row,col];
                    m[row,col] = m[col,row];
                    m[col,row] = temp;
                }


            }
        }

        static void Print(int[,] m)
        {

            int temp;
            Console.WriteLine("******************");
            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                    Console.Write( m[row,col].ToString("00") + "  ");

                Console.WriteLine();
            }
        }


        static bool Checking(int[,] m)
        {

            int over = 0, under = 0;

            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {
                    under += m[row,col];
                    over += m[col,row];
                }


            }

            return (over > under);
        }
    }
}




       