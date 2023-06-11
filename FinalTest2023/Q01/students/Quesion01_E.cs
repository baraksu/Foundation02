using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest2023
{
    public class Quesion01_e
    {
        public static bool IsZigzag(int[] arr)
        {

            int num1 = arr[0];
            int num2 = arr[1];

            for (int i = 2; i < arr.Length; i += 1)
            {
                if (num1 < num2)
                {
                    if (arr[i] > num1)
                    {
                        return false;
                    }
                }
                else
                {
                    if (arr[i] < num2)
                    {
                        return false;
                    }
                }

                num1 = arr[i];
                num2 = arr[i + 1];
            }

            return true;
        }
    }

    public class Quesion01_Barak
    {
        public static bool IsZigzag(int[] arr)
        {
            int i;
            int dn = arr[1] < arr[0] ? 1 : 2;
            int up = arr[1] < arr[0] ? 2 : 1;

            for (i = up; i < arr.Length; i += 2)
            {
                if (arr[i] < arr[i - 1])
                {
                    return false;
                }
            }

            for (i = dn; i < arr.Length; i += 2)
            {
                if (arr[i] > arr[i - 1])
                {
                    return false;
                }
            }

            return true;

        }
    }
}