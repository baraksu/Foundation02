using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap4Example01Damka
{

    public class Chap5Example1Damka
    {
        const int N = 8;

        public static void Main(string[] args)
        {
            char[,] board = new char[N, N];
            int i, j;
            // השמת ערכים
            for (i = 0; i < N; i++)
            for (j = 0; j < N; j++)
                if ((i + j) % 2 == 0)
                    board[i, j] = 'b';
                else
                    board[i, j] = 'w';


            // הדפסת ערכים
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                    Console.Write(board[i, j] + " ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
