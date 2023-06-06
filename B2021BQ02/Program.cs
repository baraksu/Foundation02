using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace B2021BQ02
{
    public class PairOnNums
    {
        private int _num1;
        private int _num2;

        public PairOnNums(int num1, int num2)
        {
            this._num1 = num1;
            this._num2 = num2;
            
        }
        public int GetNum1()
        {
            return _num1;
        }

        public int GetNum2()
        {
            return _num2;
        }

        private int GetFirstDigit(int number)
        {
            while (number /10 > 0)
            {
                number = number / 10;
            }
            return number;
        }

        private int GetLastDigit(int number)
        {
            return number % 10;
        }

        public bool EndStart()
        {
            return GetFirstDigit(_num1) == GetLastDigit(_num2) ||
                   GetFirstDigit(_num2) == GetLastDigit(_num1);
        }

       
    }
    internal class Program
    {
        public static PairOnNums[] Generate(int n)
        {
            PairOnNums[] pairs = new PairOnNums[n];
            int index = 0;
            Random r = new Random();

            while (index < n)
            {
                //Random r = new Random();

                int num1 = r.Next(1, 1001);
                int num2 = r.Next(1, 1001);

                PairOnNums p = new PairOnNums(num1, num2);

                if (p.EndStart())
                {
                    pairs[index] = p;
                    index++;
                }

            }

            return pairs;



        }
        static void Main(string[] args)
        {
            //PairOnNums p = new PairOnNums(510,45457);


            //int first = p.GetFirstDigit(94654);
            //Console.WriteLine(first);
            
            //Console.WriteLine(p.EndStart());

            PairOnNums[] p1 = Generate(2);


        }
    }
}
