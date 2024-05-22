using System;

namespace Chap3Example11BuilderArr
{
    public class Chap3Example11BuildArr
    {
        const int N = 8;
        public static void Main(string[] args)
        {
            int[] numbers = new int[N];
            int j = 1, num; numbers[0] = int.Parse(Console.ReadLine());
            // העברת הנתון הראשון למערך

            for (int i = 1; i < N; i++)
            {
                Console.WriteLine("Enter  a number:");
                num = int.Parse(Console.ReadLine());
                if (num != numbers[j - 1]) //אם הקלט שונה מערך האיבר האחרון במערך
                {
                    // הוספת הקלט למערך
                    numbers[j] = num;

                    j++; // הגדלת אינדקס המערך
                }
            }
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadKey();
        }
    }
}