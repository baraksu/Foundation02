using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chap3Example12LowMath
{
    using System;

    public class Chap3Example12LowMath
    {
        const int N = 8;
        // פעולה המייצרת מערך, קולטת אליו נתונים ומחזירה אותו
        public static int[] Kelet()
        {
            int[] g = new int[N];
            for (int i = 0; i < g.Length; i++)
            {
                Console.WriteLine("Enter  grade for student " + (i + 1));
                g[i] = int.Parse(Console.ReadLine());
            }
            return g;
        }
        public static int[] Below60(int[] g1, int[] g2)
        {
            int[] g3 = new int[g1.Length];
            int k = 0;
            for (int i = 0; i < g1.Length; i++)
            {
                if ((double)(g1[i] + g2[i]) / 2 < 60)
                {
                    g3[k] = i + 1;
                    k++;
                }
            }
            int[] g4 = new int[k];
            //יצירת מערך חדש בגודל מדוייק
            for (int i = 0; i < k; i++)
                g4[i] = g3[i];
            //העתקת האיברים למערך החדש
            return g4;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Test1");
            int[] grd1 = Kelet();
            Console.WriteLine("Test2");
            int[] grd2 = Kelet();
            int[] grd3 = Below60(grd1, grd2);
            for (int i = 0;
        i < grd3.Length;
        i++) Console.WriteLine(grd3[i]);
        }
    }
}
