using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagrut2020Q02
{
    public class AllWeights
    {
        private Weight[] arr;

        public AllWeights(int n)
        {
            arr = new Weight[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = new Weight (i,i);
            }
        }

        public Weight Sum()
        {
            Weight sumObj = new Weight();
            for (int i = 0; i < arr.Length; i++)
            {
                sumObj.Add(arr[i]);
            }
            return sumObj;
        }
    }
}
