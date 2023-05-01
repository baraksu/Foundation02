using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Part_03
{
    public class Chap3Example9GymCounter
    {
        const int N = 71;
        public static void Main(string[] args)

        {
            int[] counter = new int[N];
            int age, max, num;
            for (int i = 0; i < N; i++)
                counter[i] = 0;
            Console.WriteLine("Type number of gymnasts ");
            
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                age = int.Parse(Console.ReadLine());
                counter[age]++;
            }
            
            max = 1;
            for (int i = 2; i < N; i++)
                if (counter[i] > counter[max])
                    max = i; 
            
            Console.WriteLine("The common ages are");
            for (int i = 1; i < N; i++)
                if (counter[i] == counter[max])
                    Console.Write(i + ",");
            
            Console.WriteLine("There are no gymnast in these ages ");
            for (int i = 1; i < N; i++)
                if (counter[i] == 0)
                    Console.Write(i + ",");
        }
    }


}
