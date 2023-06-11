using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagrut_2023Q01
{
    
        internal class Program
        {
            const int N = 5;
            static void Main(string[] args)
            {
                int[] arr1 = new int[N];
                for (int i = 0; i < N; i++)
                {
                    arr1[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();

                if (PosOrder(arr1) == true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                Console.ReadKey();
            }
            public static bool PosOrder(int[] arr1)
            {
                int x = 0;
               
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] > 0)
                    {
                        if (arr1[i] >= x)
                        {
                            x = arr1[i];
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }

