using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Array01
{
    internal class Array01
    {
        static void Main(string[] args)
        {

            //Definition


            int[] array01 = new int[5];
            int[] array02;
            array02 = new int[5];

            //// more options C# 3
            int[] array03 = { 1, 2, 3, 4, 5 };



            // item in the Array [0 - (length-1)]

            int num1 = array01[3];
            int num2 = array01[GetIndex()];


            // Lenght of Array
            int length = array01.Length; // number of items



            // loop over array.
            for (int i = 0; i < array01.Length; i++)
            {
                array01[i] = array01[i] + 2;
            }



            // דוגמא 3 עמוד 38
            Quesion3Page38();

            // פעולות
            // עמ 49 שאלה 7
            Quesion7Page49();

        }

        private static void Quesion7Page49()
        {
            const int N = 31;

            int[] month1 = new int[N];
            int[] month2 = new int[N];

            Console.WriteLine("Enter data for the first month");

            for (int i = 0; i < N; i++)
            {
                month1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter data for the second month");

            for (int i = 0; i < N; i++)
            {
                month2[i] = int.Parse(Console.ReadLine());
            }

            double avg1 = Avg(month1);
            double avg2 = Avg(month2);

            if (avg2 * 1.25 <= avg1)
            {
                Console.WriteLine("yes");
            }
            {
                Console.WriteLine("no");
            }
        }

        private static void Quesion3Page38()
        {
            double[] heights = new double[20];
            double sum = 0;
            double avg = 0;
            int aboveAvg = 0;

            Console.WriteLine("Enter jumps for 20 students");

            for (int i = 0; i < 20; i++)
            {
                heights[i] = double.Parse(Console.ReadLine());
                sum += heights[i];
            }
            avg = sum / 20;

            Console.WriteLine("The avg is " + avg);

            // ספירה והצגה של מספרם הסידורי של התלמידים שקפצו מעל הממוצע
            for (int i = 0; i < 20; i++)
            {
                if (heights[i] > avg)
                {
                    aboveAvg++; // talk about ++a vs a++
                    Console.WriteLine($"Student number {i + 1} passed the average");

                }
               
            }
            Console.WriteLine($"{aboveAvg} above the avg");
        }

        public static double Avg(int[] month)
        {
            double sum = 0;
            for (int i = 0; i < month.Length; i++)
            {
                sum += month[i];
            }
            return sum / month.Length;
        }

        public static int GetIndex()
        {
            return 2;
        }
    }
}
