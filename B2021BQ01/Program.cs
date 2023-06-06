using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace B2021BQ01
{
    internal class Program
    {
        /// <summary>
        /// ["abab"] => true
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsDouble(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;
            if (str.Length %2 != 0)
                return false;
            
            int lenOneString = str.Length /2;

            for (int i = 0; i < lenOneString; i++)
            {
                if (str[i] != str[i+lenOneString])
                {
                    return false;
                }
            }
            return true;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsDouble("abab"));
            Console.WriteLine(IsDouble("abcab"));

        }
    }
}
