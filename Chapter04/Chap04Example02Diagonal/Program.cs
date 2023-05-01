using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap04Example02Diagonal
{
    internal class Program
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[,] m = new int[3, 3];
            //אלכסון ראשי
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    // i=j
                    //
                   
                    //i+j = m.GetLength(0)-1
                }

            }

            for (int i = 0; i < m.GetLength(0); i++)
            {
                //  m[i,i]

                // m[i,n-i-1]
            }
        }
    }
}
