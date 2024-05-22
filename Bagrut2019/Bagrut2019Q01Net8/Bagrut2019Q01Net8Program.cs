namespace Bagrut2019Q01Net8
{
    public class Bagrut2019Q01Net8Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
            //int[]
            //    string[]
            //        double[]
            //            Song[]
        }

        public static int Exact(string[] arr, int num)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == num)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
