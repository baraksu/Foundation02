using Matkonet2025.Q04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Matkonet2025.Q05;
using Matkonet2025.Q06;

namespace Matkonet2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("-- Q1 --");
            //int[] arr = { 153, 152, 80, 1000 };
            //Console.WriteLine($"{arr[0]}:{IsSpecial(arr[0])}");
            //Console.WriteLine($"{arr[1]}:{IsSpecial(arr[1])}");
            //Console.WriteLine($"{arr[2]}:{IsSpecial(arr[2])}");
            //Console.WriteLine($"{arr[3]}:{IsSpecial(arr[3])}");


            //int[] specials = GetSpecials(arr);
            //PrintArray(specials);

            //Console.WriteLine("-- Q2 --");
            //int[] stones1 = { 11, 8, 3, 6, 8, 6, 3, 3, 8, 8 };
            //PrintArray(stones1);
            //Console.WriteLine($"HasSameTimes:{HasSameTimes(stones1)}");

            //int[] stones2 = { 11, 8, 3, 6, 8, 6, 3, 3, 8 };
            //PrintArray(stones2);
            //Console.WriteLine($"HasSameTimes:{HasSameTimes(stones2)}");

            //Console.WriteLine("-- Q4 --");
            //Lesson l1 = new Lesson("math1", 1, true);
            //Lesson l2 = new Lesson("math2", 2, true);
            //Lesson l2A = new Lesson("math2A", 2, true);
            //Lesson l3 = new Lesson("math3", 3, false);
            //Lesson l3B = new Lesson("math3", 3, false);

            //Console.WriteLine($"l1.duration == l2.duration:{l1.SameDuration(l2)}");
            //Console.WriteLine($"l2.duration == l2A.duration:{l2.SameDuration(l2A)}");

            //Lesson[] arr = { l1, l2, l2A, l3, l3B }; 
            //Console.WriteLine($"Count l3:{CountSubject(arr, l3)}");
            //Console.WriteLine($"LongestMandatory:{LongestMandatory(arr)}");

            //Console.WriteLine("-- Q5 --");


            //// Create 5 Song objects  
            //Song song1 = new Song("Song A1", 1, true);
            //Song song2 = new Song("Song B", 2, true);
            //Song song3 = new Song("Song C1", 1, true);
            //Song song4 = new Song("Song D", 2, true);
            //Song song5 = new Song("Song E1", 1, true);
            //Song song6 = new Song("Song F2", 2, true);
            //Song song7 = new Song("Song G3", 3, true);

            //// Create a Contest object  
            //Contest contest = new Contest();

            //// Add songs to the contest  
            //contest.Add(song1);
            //contest.Add(song2);
            //contest.Add(song3);
            //contest.Add(song4);
            //contest.Add(song5);
            //contest.Add(song6);
            //contest.Add(song7);

            //// Call the MaxSongs method to find the country with the most songs  
            //contest.MaxSongs();

            Console.WriteLine("-- Q6 --");


            Car car5 = new Car("A25", 2020, 25);
            Car car3 = new Car("A18", 2018, 18);
            Car car2 = new Car("A20", 2015, 20);
            Car car1 = new Car("A15", 2012, 15);
            Car car4 = new Car("A22", 2010 ,22);
            Car car7 = new Car("A15", 2008, 14);
            Car car9 = new Car("A17", 2007, 17);
            Car car6 = new Car("A12", 2005, 12);
            Car car8 = new Car("A16", 2003, 16);
            Car car10= new Car("A19", 2001, 19);
            CarStore store = new CarStore();
            Car[] arr = new Car[] { car1, car2, car3, car4, car5, car6, car7,null, car8, car9, car10 };
            store.SetCars(arr);
            store.LessAvgKm();

            Car[] sortedCars = SortedCars(store);
            Console.WriteLine("Sorted Cars (2010-2020):");
            foreach (Car car in sortedCars)
            {
                if (car != null)
                {
                    Console.WriteLine($"License: {car.GetLicense()}, Year: {car.GetYear()}, Km: {car.GetKm()}");
                }
            }


            Console.ReadKey();
        }
        public static int CountSubject(Lesson[] arr, Lesson l)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (l.GetSubject() == arr[i].GetSubject() && l.GetDuration() == arr[i].GetDuration())
                //if (l.SameDuration(arr[i])  && arr[i].SameSubject(l))
                {
                    count++;
                }
            }
            return count;
        }

        public static string LongestMandatory(Lesson[] arr)
        {
            int maxDuration = -1;
            string maxSubject = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].GetIsMandatory() && arr[i].GetDuration() > maxDuration)
                {
                    maxDuration = arr[i].GetDuration();
                    maxSubject = arr[i].GetSubject();
                }
            }
            return maxSubject;
        }

        private static void PrintArray(int[] specials)
        {
            for (int i = 0; i < specials.Length; i++)
            {
                Console.Write(specials[i] + ",");
            }
        }

        public static bool HasSameTimes(int[] stones)
        {
            // מערך מונים
            // מציאת מונה זהה
            int[] counters = new int[101];

            for (int i = 0; i < stones.Length; i++)
            {
                counters[stones[i]] += 1;
            }

            // פעולת קיים
            for (int i = 0; i < counters.Length - 1; i++)
            {
                for (int k = i + 1; k < counters.Length; k++)
                {
                    if (counters[i] == counters[k] && counters[i] != 0)
                        return true;
                }
            }
            return false;
        }

        public static int[] GetSpecials(int[] arr)
        {
            // מערך לפי תנאי
            // בדוק את המספר של העונים על התנאי
            // בנה מערך אם האיברים המתאימים
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsSpecial(arr[i]))
                {
                    count++;
                }
            }
            int[] specials = new int[count];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsSpecial(arr[i]))
                {
                    specials[index] = arr[i];
                    index++;
                }
            }
            return specials;
        }

        public static bool IsSpecial(int num)
        {
            if (num < 100 || num > 999)
            {
                return false;
            }
            int sum = 0;
            int digit = 0;
            int number = num;
            while (number != 0)
            {
                digit = number % 10;
                sum += digit * digit * digit;
                number = number / 10;
                //sum =(int) Math.Pow(digit, 3);
            }
            return sum == num;
        }
        public static Car[] SortedCars(CarStore store)
        {
            // Get all cars from the store  
            Car[] allCars = store.GetCars();
            int count = 0;
            for (int i = 0; i < allCars.Length; i++)
            {
                if (allCars[i] != null && allCars[i].GetYear() >= 2010 && allCars[i].GetYear() <= 2020 )
                {
                    count++;
                }
            }
            Car[] sortedCars = new Car[count];
            int index = 0;
            for (int i = 0; i < allCars.Length; i++)
            {
                if (allCars[i] != null && allCars[i].GetYear() >= 2010 && allCars[i].GetYear() <= 2020)
                {
                    sortedCars[index] = allCars[i];
                    index++;

                }
            }
            // Sort the cars by year in descending order
            for (int i = 0; i < sortedCars.Length ; i++)
            {
                for (int j = i + 1; j < sortedCars.Length; j++)
                {
                    if (sortedCars[i].GetYear() > sortedCars[j].GetYear())
                    {
                        // Swap the cars
                        Car temp = sortedCars[i];
                        sortedCars[i] = sortedCars[j];
                        sortedCars[j] = temp;
                    }
                }
            }

            return sortedCars;
        }
    }
}
