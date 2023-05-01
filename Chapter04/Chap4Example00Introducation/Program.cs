using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap4Example00Introducation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //חד ממדי
            int[] counter = new int[5];

            //מערך דו ממדי
            int[,] heights = new int[10, 3];// שורות10 עמודות3
            heights[2, 3] = 6;// שורה2 עמודה3

            //קליטת נתונים
            int[,] mat = new int[5, 4];//שורות5 עמודות4
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }

            }



        }
    }
}
